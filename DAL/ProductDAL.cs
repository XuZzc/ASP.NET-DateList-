using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        /// <summary>
        /// 查询所有的产品列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetProductList() {
            string sql = "select * from Product";
            return DBHelper.Select(sql);
        }
        /// <summary>
        /// 查询列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetProductListall()
        {
            string sql = "select * from ProductClass";
            return DBHelper.Select(sql);
        }

        /// <summary>
        /// 根据id删除商品数据
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static bool DeleteById(int pid) {
            string sql = string.Format("delete from  Product where ProductID={0}", pid);
            return DBHelper.Update(sql);
        }
        /// <summary>
        /// 查询id对应的产品列表
        /// </summary>
        /// <returns></returns>
        public static DataTable Select(int id)
        {
            string sql = string.Format("select * from Product ,ProductClass where Product.ClassID =ProductClass.ClassID and Product.ClassID='{0}' ", id);
            return DBHelper.Select(sql);
        }
    }
}
