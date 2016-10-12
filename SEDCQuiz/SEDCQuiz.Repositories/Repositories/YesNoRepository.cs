using SedcQuiz.Interfaces;
using SEDCQuiz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDCQuiz.Repositories.Repositories
{
    public class YesNoRepository : IYesNoRepository
    {
        Database db = new Database();

        public void Create(YesNo yesNo)
        {
            db.YesNo.Add(yesNo);
            db.SaveChanges();
        }

        public List<YesNo> GetAll()
        {
            return db.YesNo.ToList();
        }

        public YesNo GetQuestion()
        {
            return db.YesNo.First();
        }

        public YesNo GetQuestionById(int id)
        {
            return GetAll().FirstOrDefault(x => x.ID == id);
        }
    }
}
