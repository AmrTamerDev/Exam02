using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class TrueAndFalseQuestion : Question
    {
      
        #region Methods
        public void ReadQuestionTrueAndFalse()
        {
            Console.Clear();
            HeaderOfQuestion = "True | False Question";
            Console.WriteLine(HeaderOfQuestion);
            Console.WriteLine("Please Enter Question Body");
            BodyOfQuestion = Console.ReadLine();
            Console.WriteLine("Please Enter Question Mark");
            Mark = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the right Answer id (1 For True | 2 For False)");
            AnswerID = int.Parse(Console.ReadLine());
            QuestionChoice = 2;
        }
        #endregion
    }
}
