using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIQ.Models
{
    public class QuestionModel
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public string NeAnswer
        {
            get
            {
                bool convert = !(bool.Parse(Answer));
                return convert.ToString();
            }       
        }
    }
}
