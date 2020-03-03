using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;

namespace BaiDuTuiGuang
{
    public static class DataTableExtensions
    {
        /// <summary>
        /// List 转换成Datatable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public delegate object[] CreateRowDelegate<T>(T t);
        static public DataTable ToDataTable<T>(this IEnumerable<T> varlist, CreateRowDelegate<T> fn)
        {
            //存表的列名
            DataTable dtReturn = new DataTable();

            // 访问属性元素
            PropertyInfo[] oProps = null;

            // 判断属性元素大于0就遍历

            foreach (T rec in varlist)
            {

                // 用反射来获取属性名，创建表，只执行第一次
                if (oProps == null)
                {
                    //得到公有属性
                    oProps = ((Type)rec.GetType()).GetProperties();
                    //遍历属性中的数据
                    foreach (PropertyInfo pi in oProps)
                    {
                        //获取属性的名称与类型   


                        Type colType = pi.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                        {

                            colType = colType.GetGenericArguments()[0];

                        }

                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));

                    }

                }
                //将数据填充到行中
                DataRow dr = dtReturn.NewRow();
                foreach (PropertyInfo pi in oProps)
                {

                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue(rec, null);

                }

                dtReturn.Rows.Add(dr);

            }

            return (dtReturn);

        }

    }
}
