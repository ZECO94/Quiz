using System.Threading.Channels;

namespace Quiz_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] question1 = new Question[]
            {
                new Question ("What is the Capital of Palastine ?", new string[] {"Quds","Cairo","Amman","Tunis" } , 0)
            };





            Quiz quiz1 = new Quiz(question1);
            quiz1.DisplayQuestion(question1[0]);
            
        }
        
    }
}
