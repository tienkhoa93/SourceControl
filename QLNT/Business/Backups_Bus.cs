
namespace QLNT.Business
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using QLNT.LinQToSQL;
    public class Backups_Bus
    {
        QLNTDataContext dtcontent = new QLNTDataContext();
        public bool InsertBackups(Backupss bk)
        {
            try
            {
                dtcontent.Backupsses.InsertOnSubmit(bk);
                dtcontent.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public Backupss GetListBackups()
        {
            return (from t in dtcontent.Backupsses select t).First();
        }
        // hien tai dang bi loi.
        public bool UpdateBackup(Backupss bk)
        {
            try
            {
                LinQToSQL.Backupss backup = dtcontent.Backupsses.Single(p => p.Id == bk.Id);
                backup.Onn = bk.Onn;
                backup.Ngay = bk.Ngay;
                backup.TrangThai = bk.TrangThai;
                dtcontent.SubmitChanges();
                return true;
            }
            catch { return false; }

        }
        public bool DaBackup()
        {
            try
            {
                LinQToSQL.Backupss backup = dtcontent.Backupsses.Single(p => p.Id == 0);
                backup.TrangThai = true;
                dtcontent.SubmitChanges();
                return true;
            }
            catch { return false; }

        }
        public bool ChuaBackup()
        {
            try
            {
                LinQToSQL.Backupss backup = dtcontent.Backupsses.Single(p => p.Id == 0);
                backup.TrangThai = false;
                dtcontent.SubmitChanges();
                return true;
            }
            catch { return false; }

        }
    }
}
