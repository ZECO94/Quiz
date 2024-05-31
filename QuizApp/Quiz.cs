using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App
{
    internal class Quiz
    {
        private Question[] questions;

    public Quiz(Question[] questions) 
        {
            this.questions = questions;
        }
        public void DisplayQuestion(Question question)
        
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("I                       Question                         I");
            Console.WriteLine("==========================================================");
            Console.WriteLine(question.QuestionText);
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"  {i+1})");
                Console.ResetColor();
                Console.WriteLine($" {question.Answers[i]}");
                
            }
            if (CheckAnswer() == question.CorrectAnswerIndex)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Correct !");
                Console.ResetColor();
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not Correct !");
                Console.ResetColor();
                
            }
        }
    public int CheckAnswer()
        {
            Console.Write("Enter Your Choice : ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input,out choice) || (choice < 0)|| (choice > 4)) 
            {
                Console.WriteLine("Invalid Choice ....");
                input = Console.ReadLine();
            }
            return choice - 1 ;
        }
    }
}
