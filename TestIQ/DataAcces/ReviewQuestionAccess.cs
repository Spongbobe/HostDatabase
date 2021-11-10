using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIQ.DataAcces
{
    public class ReviewQuestionAccess
    {
        public List<Models.ReviewQuestionModel> LoadReviewQuestion()
        {
            using (IDbConnection con = new SQLiteConnection(SqlHelper.GetConnectionString("default3")))
            {
                var output = con.Query<Models.ReviewQuestionModel>("select * from ReviewTb").ToList();

                return output;
            }

        }

        public async Task AddQuestion(Models.ReviewQuestionModel Reviewquestion)
        {
            using (IDbConnection con = new SQLiteConnection(SqlHelper.GetConnectionString("default3")))
            {
                await con.ExecuteAsync("insert into ReviewTb(TeacherName,Score,ReviewTime) values(@TeacherName,@Score,@ReviewTime) ", Reviewquestion);
            }

        }
    }
}
