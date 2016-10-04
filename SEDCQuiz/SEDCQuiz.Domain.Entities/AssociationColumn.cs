using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDCQuiz.Domain.Entities
{
    public class AssociationColumn
    {
        public int ID { get; set; }
        public string TermOne { get; set; }
        public string TermTwo { get; set; }
        public string TermThree { get; set; }
        public string TermFour { get; set; }
        public string ColumnAnswer { get; set; }

        public virtual Association Association { get; set; }
        public virtual int AssociationID { get; set; }
    }
}
