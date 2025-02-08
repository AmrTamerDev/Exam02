using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class MCQQuestion : Question
    {
      
        #region Methods
        public void ReadQuestionMCQ()
        {
            Console.Clear();
            HeaderOfQuestion = "MCQ Question";
            Console.WriteLine(HeaderOfQuestion);
            Console.WriteLine("Please Enter Question Body");
            BodyOfQuestion = Console.ReadLine();
            Console.WriteLine("Please Enter Question Mark");
            Mark = int.Parse(Console.ReadLine());
            Console.WriteLine("Choices of Question");
       
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Please Enter Choice Number {i + 1}");
                ChoiceOfQuestions[i] = Console.ReadLine();
            }
            Console.WriteLine("Please Enter the right Answer id");
            AnswerID = int.Parse(Console.ReadLine());
            QuestionChoice = 1;
        }
        #endregion
    }
}
