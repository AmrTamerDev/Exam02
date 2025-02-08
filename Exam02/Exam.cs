using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Exam
    {
        #region Attributes
        private int typeOfExam;
        private int timeOfExam;
        private int numberOfQuestion;
  
        
        #endregion

        #region Constructor
        public Exam()
        {

        }
        public Exam(int TimeOfExam, int NumberOfQuestion)
        {
            timeOfExam = TimeOfExam;
            numberOfQuestion = NumberOfQuestion; 
        }
        #endregion

        #region Properties
        public int TypeOfExam
        {
            get { return typeOfExam; }
            set { typeOfExam = value; }
        }

        public int TimeOfExam
        {
            get { return timeOfExam; }
            set { timeOfExam = value; }
        }

        public int NumberOfQuestion
        {
            get { return numberOfQuestion; }
            set { numberOfQuestion = value; }
        }


        #endregion

        #region Methods 

        private int ReadTimeOfExam()
        {
            int ReadNumber;
            Console.WriteLine("Please Enter the time For Exam from (30 min to 180 min)");
            ReadNumber = int.Parse(Console.ReadLine());
            return ReadNumber;
        }

        private int ReadNumberOfQuestion()
        {
            int ReadNumber;
            Console.WriteLine("Please Enter the Number Of questions");
            ReadNumber = int.Parse(Console.ReadLine());
            return ReadNumber;
        }

        public void ShowExam()
        { 
            Console.WriteLine("Please Enter The Type Of Exam(1 For Practical | 2 For Final)");
            typeOfExam = int.Parse(Console.ReadLine());
            if (typeOfExam == 1)
             { PracticalExam practicalExam = new PracticalExam(ReadTimeOfExam(), ReadNumberOfQuestion()); }
            else if (typeOfExam == 2)
             { FinalExam finalExam = new FinalExam(ReadTimeOfExam(), ReadNumberOfQuestion()); }
        }
        #endregion
    }
}
