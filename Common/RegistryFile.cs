using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Common
{
  public  class RegistryFile
    {
        const string REGISTRYPATH = @"HKEY_CURRENT_USER\SOFTWARE\QLkTX";
        const string REGISTRYKEYNAME = "Rememberuser";
        const string REGISTRYKEYNAMESTT = "STT";
        const string REGISTRYKEYNAMEAccount = "Account";
        const string REGISTRYKEYNAMEPASS = "Pass";
        const string REGISTRYKEYNAMESkin = "Skin";     
        const string KEY = "ktx@123";
        public static bool GhiUser(bool stt,string txtuser, string txtpass,string skin)
        {
            
            try
            {
                    Registry.SetValue(REGISTRYPATH, REGISTRYKEYNAMESTT, stt);
                    Registry.SetValue(REGISTRYPATH, REGISTRYKEYNAMEAccount, MaHoa.MaHoaDES(KEY, txtuser));
                    Registry.SetValue(REGISTRYPATH, REGISTRYKEYNAMEPASS, MaHoa.MaHoaDES(KEY, txtpass));
                    Registry.SetValue(REGISTRYPATH, REGISTRYKEYNAMESkin, MaHoa.MaHoaDES(KEY, skin));
                    return true;
            }
            catch {
                return false;
            }           
        }

        public static void ReadRegistry()
        {          
            try
            {
                UserInfo.Stt = bool.Parse( Registry.GetValue(REGISTRYPATH, REGISTRYKEYNAMESTT, "").ToString());
                UserInfo.Account = MaHoa.GiaiMaDES(KEY, Registry.GetValue(REGISTRYPATH, REGISTRYKEYNAMEAccount, "").ToString());
                UserInfo.Pass = MaHoa.GiaiMaDES(KEY, Registry.GetValue(REGISTRYPATH, REGISTRYKEYNAMEPASS, "").ToString());
                UserInfo.Skin = MaHoa.GiaiMaDES(KEY, Registry.GetValue(REGISTRYPATH, REGISTRYKEYNAMESkin, "").ToString());
            }
            catch { }
        }
    }
}
