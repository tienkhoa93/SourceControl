using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using QLNT.LinQToSQL;
namespace QLNT.Business
{
    public class Log_Bus
    {
        QLNTDataContext dtcontext = new QLNTDataContext();
        /// <summary>
        /// truyền thông số tác vụ và chi tiết xuống
        /// </summary>
        /// <param name="tv"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        /// 
        public void InsertLog(String tv = null, String ct = null)
        {
            dtcontext.NT_TGG_LOG(UserInfo.Account, tv, ct, UserInfo.MacAdd, UserInfo.NameComputer);
            try
            {
                dtcontext.SubmitChanges();
            }
            catch { }

        }
        public List<LinQToSQL.NhatKy> ListNhatKy()
        {
            var nk = from n in dtcontext.NhatKies select n;
            return nk.ToList<NhatKy>();
        }
        public void DeleteAll()
        {
            try
            {
                dtcontext.NT_SP_DELETE_ALL_NHATKY();
                dtcontext.SubmitChanges();
            }
            catch { }

        }
        public void DeleteList(List<int> list)
        {
            foreach (int i in list)
            {
                dtcontext.NhatKies.DeleteOnSubmit((from nk in dtcontext.NhatKies where nk.STT == i select nk).First());
                dtcontext.SubmitChanges();
            }
        }
    }
}
