using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class FinalExam : Exam
    {
        public int TypeOfQuestion { get; set; }
        private List<Question> questions;
        TimeSpan duration;
        public FinalExam(int TimeOfExam, int NumberOfQuestion) : base(TimeOfExam, NumberOfQuestion)
        {
            ShowExamQuestion();
            ShowAnswerQuestion();
            ShowFinalResult();
        }

        public void ShowExamQuestion()
        {
            questions = new List<Question>();
            for (int Number = 0; Number < NumberOfQuestion; Number++)
            {
                Console.Clear();
                Console.WriteLine("Please Enter Type Of Question (1 For MCQ | 2 For True | False)");
                TypeOfQuestion = int.Parse(Console.ReadLine());

                if (TypeOfQuestion == 1)
                {
                    Console.Clear();
                    MCQQuestion mcq = new MCQQuestion();
                    mcq.ReadQuestionMCQ();
                    questions.Add(mcq);

                }
                else if (TypeOfQuestion == 2)
                {
                    Console.Clear();
                    TrueAndFalseQuestion tf = new TrueAndFalseQuestion();
                    tf.ReadQuestionTrueAndFalse();
                    questions.Add(tf);
                }
            }
        }

        public void ShowAnswerQuestion()
        {
            Console.Clear();
            char Choice = 'n';
            Console.WriteLine("Do You Want To Start Exam (Y|N)");
            Choice = char.Parse(Console.ReadLine());
            if (char.ToUpper(Choice) == 'Y')
            {
                foreach (Question question in questions)
                {
                    DateTime startTime = DateTime.Now;
                    Console.Clear();
                    Console.WriteLine($"{ question.HeaderOfQuestion}       Mark {question.Mark}");
                    Console.WriteLine(question.BodyOfQuestion);
                    if (question.QuestionChoice == 1)
                    {
                        for (int i = 0;i < 3; i++)
                        {
                            Console.WriteLine(question.ChoiceOfQuestions[i]);
                        }
                        Console.WriteLine("Please Enter The Answer Id");
                        question.AnswerText = int.Parse(Console.ReadLine());

                    }
                    else
                    {
                        Console.WriteLine($"{question.HeaderOfQuestion}       Mark {question.Mark}");
                        Console.WriteLine(question.BodyOfQuestion);
                        Console.WriteLine("1-True");
                        Console.WriteLine("2-False");
                        Console.WriteLine("Please Enter The Answer Id (1 For True | 2 For False)");
                        question.AnswerText = int.Parse(Console.ReadLine());
                     
                    }
                    DateTime endTime = DateTime.Now;
                    duration = endTime - startTime;
                }
            }
        }

        public void ShowFinalResult()
        {
            int TotalAnswerRight = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                Question question = questions[i];
                Console.Clear();
                Console.WriteLine($"Question {i + 1} : {question.BodyOfQuestion}");
                Console.WriteLine($"Your Answer => {question.AnswerText}");
                Console.WriteLine($"Right Answer => {question.AnswerID}");
                if (question.AnswerText == question.AnswerID)
                {
                    TotalAnswerRight += question.Mark;
                }
            }
            Console.WriteLine($"Time = {duration.Hours}:{duration.Minutes}:{duration.Seconds}");
            Console.WriteLine("Thank You");
        }
    }
}
