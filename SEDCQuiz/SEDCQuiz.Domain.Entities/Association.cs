using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDCQuiz.Domain.Entities
{
    public class Association
    {
        public int ID { get; set; }
        public string FinalAnswer { get; set; }
        
        public virtual Game Game { get; set; }
        public virtual int GameID { get; set; }
    }
}
