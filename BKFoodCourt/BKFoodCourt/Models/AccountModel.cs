using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace BKFoodCourt.Models
{
    public class AccountModel
    {
        public AccountDBContext context = null;

        public AccountModel()
        {
            context = new AccountDBContext();
        }
        public bool Login(string Email, string PassWord)
        {
            object[] sqlParams =
            {
                new SqlParameter("@Email",Email),
                new SqlParameter("@PassWord",PassWord)
            };
            var res = context.Database.SqlQuery<bool>("LoginAccount @Email,@PassWord", sqlParams).SingleOrDefault();
            return res;
        }
        public bool CheckAccount(string Email)
        {
            object[] sqlParams =
            {
                new SqlParameter("@Email",Email)
            };
            var res = context.Database.SqlQuery<bool>("CheckAccount @Email", sqlParams).SingleOrDefault();
            return res;
        }
    }
}