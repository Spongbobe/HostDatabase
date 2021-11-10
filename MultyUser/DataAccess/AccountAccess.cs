using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MultyUser.DataAccess
{
    public class AccountAccess
    {
        string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDb;Integrated Security=True;";
        public List<Models.Account> LoadUserData()
        {
            using(IDbConnection connection = new SqlConnection(con))
            {
                var output = connection.Query<Models.Account>("select * from dbo.CustomerDt inner join dbo.acountTb on dbo.acountTb.Id  = dbo.CustomerDt.cId");

                return output.ToList();
            }


        }

        //Get all acounts
        public List<Models.Account> GetAllUserAccount()
        {
            using (IDbConnection connection = new SqlConnection(con))
            {
                var output = connection.Query<Models.Account>("select acount from dbo.acountTb");

                return output.ToList();
            }


        }
        //Get all acountsData
        public List<Models.Account> GetAccountData(string _userAccount)
        {
            using (IDbConnection connection = new SqlConnection(con))
            {
                var output = connection.Query<Models.Account>($"select * from dbo.CustomerDt inner join dbo.acountTb on dbo.acountTb.Id  = dbo.CustomerDt.cId where dbo.acountTb.acount = '{_userAccount}'; ");
                return output.ToList();
            }


        }


    }
}
