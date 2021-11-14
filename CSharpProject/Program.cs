using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CSharpProject
{
    internal class Program
    {
        static string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDb;Integrated Security=True;";
        static void Main(string[] args)
        {
            InsertData();
        }
        static void InsertData()
        {
            //InsertData();
            //InsertwithScalar();
            //AnonymousType();
            StrongType_Multi_Mapping();
        }

        //Method 1
        static void InsertwithTable()
        {
            using (System.Data.IDbConnection con = new System.Data.SqlClient.SqlConnection(constr))
            {

                var reader = con.ExecuteReader("SELECT * FROM dbo.acountTb;");

                System.Data.DataTable table = new System.Data.DataTable();
                table.Load(reader);

                foreach (System.Data.DataRow item in table.Rows)
                {
                    Console.WriteLine(item.ItemArray[1]);
                }

            }
        }


        //use to return the first cell ot table
        static void InsertwithScalar()
        {
            using (System.Data.IDbConnection con = new System.Data.SqlClient.SqlConnection(constr))
            {

                var reader = con.ExecuteScalar<string>("SELECT * FROM dbo.acountTb;");
                Console.WriteLine(reader);
            }
        }


        //quary Anonymous type
        static void AnonymousType()
        {
            using (System.Data.IDbConnection con = new System.Data.SqlClient.SqlConnection(constr))
            {

                var reader = con.Query("select * from dbo.acountTb").ToList();

                reader.ForEach(x => Console.WriteLine(x));
            }
        }


        //StrongType_Multi_Mapping
        static void StrongType_Multi_Mapping()
        {
            using (System.Data.IDbConnection con = new System.Data.SqlClient.SqlConnection(constr))
            {

                var reader = con.Query<Items, Items2, Items>("select * from dbo.acountTb as A inner join dbo.CustomerDt as B on A.Id = B.cId",
                    (item,item2) =>
                    {
                        item.Id = item2.cId;
                        return item;
                    },
                    splitOn: "cId"
                    ).Distinct().ToList();
                
                Console.WriteLine(reader.Count);
                //reader.ForEach(x => Console.WriteLine(x.Id + " " +x.acount ));
            }
        }
    }
}
