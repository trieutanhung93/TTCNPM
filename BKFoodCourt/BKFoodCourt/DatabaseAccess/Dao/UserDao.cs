using BKFoodCourt.DatabaseAccess.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BKFoodCourt.DatabaseAccess.Dao
{
    public class UserDao
    {
        EF.BKFoodCourt db = null;
        public UserDao()
        {
            db = new EF.BKFoodCourt();
        }

        public int InsertAcc(Account entity)
        {
            //Check
            if (db.Accounts.SingleOrDefault(x => x.Email == entity.Email) == null)
            {
                db.Accounts.Add(entity);
                db.SaveChanges();
                return entity.ID;
            }
            else
            {
                return -1;
            }

        }
        public int Login(string email, string password)
        {
            Account acc = db.Accounts.SingleOrDefault(x => x.Email == email);
            if (acc != null)
            {
                acc.PassWord = acc.PassWord.Trim();
                password = password.Trim();
                if (acc.PassWord == password)
                {
                    return acc.TypeAccount;
                }
                else
                {
                    return -1;
                }
            }
            else
                return -1;
        }

        public Account GetInfo(string email)
        {
            Account acc = db.Accounts.SingleOrDefault(x => x.Email == email);
            return acc;
        }
    }
}