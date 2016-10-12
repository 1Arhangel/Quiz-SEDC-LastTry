using SEDCQuiz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedcQuiz.Interfaces
{
    public interface IYesNoRepository
    {
        void Create(YesNo yesNo);
        List<YesNo> GetAll();
        YesNo GetQuestion();
        YesNo GetQuestionById(int id);
    }
}
