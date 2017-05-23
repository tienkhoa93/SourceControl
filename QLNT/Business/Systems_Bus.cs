using Common;
using QLNT.LinQToSQL;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Business
{
   public class Systems_Bus
    {
       LinQToSQL.QLNTDataContext datacontext = new LinQToSQL.QLNTDataContext();
       Log_Bus lb = new Log_Bus();
       /// <summary>
       /// truyền vào User kiểm tra nó có tồn tại hay không
       /// </summary>
       /// <param name="us"></param>
      /// <param name="true">tài khoản tồn tại trong csdl</param>
       /// <param name="false">tài khoản không tồn tại trong csdl</param>
       /// <returns></returns>
       public bool KiemTraUser(string tk,string mk)
       {
          
           if ((from user in datacontext.SysUsers where user.TaiKhoan == tk && user.MatKhau == MaHoa.MaHoaMD5(mk) select user).Count() < 1)
               return false;
           return true;
       }
       /// <summary>
       /// Update mật khẩu mới cho user. 
       /// </summary>
       /// <param name="tk"></param>
       /// <param name="mk"></param>
       /// <returns></returns>
       public bool DoiMatKhauUser(string tk,string mk)
       {
           try {
               string mkm = MaHoa.MaHoaMD5(mk);
               
               SysUser user = datacontext.SysUsers.Single(us => us.TaiKhoan == tk);
               user.MatKhau = mkm;
               datacontext.SubmitChanges();
               lb.InsertLog("Thay đổi mật khẩu tài khoản " + tk, "thực hiện thao tác thay đổi mật khẩu cho user.");
               return true;
           }
           catch {
               return false;
           }  
       }
       public SysUser GetUser(string tk)
       {         
           // lay len tai khoan user
           var user = from us in datacontext.SysUsers 
                          where us.TaiKhoan == tk
                          select us;          
           return user.ToList<SysUser>()[0];
       }
    }
}
