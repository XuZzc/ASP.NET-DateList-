using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ProductBLL
    {
        /// <summary>
        /// 查询所有的产品列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetProductList() {
            return ProductDAL.GetProductList();
        }
         /// <summary>
        /// 查询列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetProductListall()
        {
            return ProductDAL.GetProductListall();
        }

          /// <summary>
        /// 根据id删除商品数据
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static bool DeleteById(int pid) {
            return ProductDAL.DeleteById(pid);
        }
          /// <summary>
        /// 查询id对应的产品列表
        /// </summary>
        /// <returns></returns>
        public static DataTable Select(int id)
        {
            return ProductDAL.Select(id);
        }
    }
}
