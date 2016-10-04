using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDCQuiz.Domain.Entities
{
    public class ConnectionSet
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual int GameID { get; set; }
        public virtual Games Game { get; set; }
    }
}
