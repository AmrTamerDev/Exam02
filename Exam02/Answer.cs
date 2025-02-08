using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Answer
    {
        #region Attributes
        private int answerId;
        private int answerText;
        #endregion

        #region Properties
        public int AnswerID
        { get { return answerId; } set { answerId = value; } }
        public int AnswerText
        {  get { return answerText; } set {answerText = value; } }
        #endregion


    }
}
