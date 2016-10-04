﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDCQuiz.Domain.Entities
{
    public class YesNo
    {
        public int ID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public virtual int GameID { get; set; }
        public virtual Games Game { get; set; }
    }
}
