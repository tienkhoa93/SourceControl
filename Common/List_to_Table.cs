using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
   public  static class List_to_Table
    {
        public static DataTable ToDataTable<T>(this IList<T> list)
        {
            DataTable table = new DataTable();

            
            if(list!=null)
            {
                 PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
                for (int i = 0; i < props.Count; i++)
                {
                    PropertyDescriptor prop = props[i];
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
                object[] values = new object[props.Count];
                foreach (T item in list)
                {
                    for (int i = 0; i < values.Length; i++)
                        values[i] = props[i].GetValue(item) ?? DBNull.Value;
                    table.Rows.Add(values);
                }
            }
           
            return table;
        }   
    }
}
