using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestImage.Models
{
    public class AccountDataAccess
    {
        string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDb;Integrated Security=True;";
        private List<Models.Account> LoadUserData()
        {
            using (IDbConnection connection = new SqlConnection(con))
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
                var output = connection.Query<Models.Account>("select acount,Id from dbo.acountTb");

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

        //Get acounts id
        public void AddUserData(Models.Account account)
        {
            using (IDbConnection connection = new SqlConnection(con))
            {
                var output = connection.Execute($"insert into dbo.CustomerDt(cId,ImagePath) values({account.Id},'{account.ImagePath}')");
            }
        }
    }
}
