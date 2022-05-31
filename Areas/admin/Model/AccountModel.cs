
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryOnlineShop.Areas.admin.Model;

namespace Models
{
    public class AccountModel
    {
        private OnlineShopDBContext context = null;

        public AccountModel()
        {
            context = new OnlineShopDBContext();
        }

        public bool Login(string UserName, string Password)
        {
            object[] sqlParams =
            {
                new SqlParameter("@UserName",UserName),
                new SqlParameter("@Password",Password),
            };

            var res = context.Database.SqlQuery<bool>("Account_Login @UserName,@Password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
