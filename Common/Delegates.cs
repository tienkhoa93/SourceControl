using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Common
{
    public class Delegates
    {
        #region Delegate Truyen datagrib
        public delegate void RefeshGrid(object formName);
        public static RefeshGrid Regrib;
        #endregion

        public static void GetList(object name)
        {
            try
            {
                Regrib(name);
            }
            catch { }
        }

    }
}
