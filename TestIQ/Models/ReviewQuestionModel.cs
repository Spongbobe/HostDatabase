using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIQ.Models
{
    public class ReviewQuestionModel
    {
        public string TeacherName { get; set; }
        public double Score { get; set; }
        public DateTime ReviewTime { get; set; }
        public Models.QuestionModel QuestionModel { get; set; }
       

    }
}
