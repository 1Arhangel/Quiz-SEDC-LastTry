using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDCQuiz.Domain.Entities
{
    public class ConnectionPairs
    {
        public int ID { get; set; }
        public string PairKey { get; set; }
        public string PairValue { get; set; }

        public virtual int ConnectionSetID { get; set; }
        public virtual ConnectionSet ConnectionSet { get; set; }
    }
}
