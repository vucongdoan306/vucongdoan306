using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TryOnlineShop.Areas.admin.Model
{
    public class CategoryModel
    {
        private OnlineShopDBContext context = null;

        public CategoryModel()
        {
            context = new OnlineShopDBContext();
        }

        public List<Category> ListAll()
        {
            var list = context.Database.SqlQuery<Category>("Sp_Category_ListAll").ToList();
            return list;
        }


        public int Create(string Name, string Alias, int? ParentID, int? Order, bool? Status)
        {
            object[] parameters =
            {
                new SqlParameter("@Name",Name),
                new SqlParameter("@Alias",Alias),
                new SqlParameter("@ParentID",ParentID),
                new SqlParameter("@Order",Order),
                new SqlParameter("@Status",Status)
            };
            int res = context.Database.ExecuteSqlCommand("Sp_Category_Insert @Name,@Alias,@ParentID,@Order,@Status",parameters);
            return res;
        }
    }

}