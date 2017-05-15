using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using DevExpress.LookAndFeel;
namespace QLNT.Form.Systems
{
   public class RunApplication
    {
       public RunApplication()
       {
           RegistryFile.ReadRegistry();
           // dang ky giao dien voi he thong
           Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
           DevExpress.Skins.SkinManager.EnableFormSkins();           
           DevExpress.UserSkins.BonusSkins.Register();           
           UserLookAndFeel.Default.SetSkinStyle(UserInfo.Skin);
           //

           Login connect = new Login();
              connect.ShowDialog();
           if (!connect.login)
           {
               Application.Exit();
           }
           else
           {            
               frmMain frmMain = new frmMain();
               connect.Dispose();
               frmMain.ShowDialog();
           }
       }
       
    }
}
