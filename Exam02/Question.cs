using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Question : Answer
    {
        #region Attributes
        private string headerOfQuestion;
        private string bodyOfQuestion;
        private int mark;
        public string[] ChoiceOfQuestions = new string[3];
        public int QuestionChoice; //1.For MSQ 2. For TrueAndFalse
        #endregion

        #region Properties
        public string HeaderOfQuestion
        { get { return headerOfQuestion; } set { headerOfQuestion = value; } }
        public string BodyOfQuestion
        {
            get { return bodyOfQuestion; }
            set { bodyOfQuestion = value; }
        }

        public int Mark
        { get { return mark; } set { mark = value; } }
        
        #endregion

        #region Constructor
        public Question()
        {

        }
        public Question(string HeaderOfQuestion, string BodyOfQuestion, int Mark, int SizeOfAnswer)
        {
            headerOfQuestion = HeaderOfQuestion;
            bodyOfQuestion = BodyOfQuestion;
            mark = Mark;
            
        }
        #endregion
    
        
    }
}
