using FileHandler.Services;
using System.Xml;
using System.Xml.Linq;

namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 1;
            string? q, a;


            while (userChoice != 0)
            {
                Console.WriteLine("Enter your choice: \n" +
                    "1 - Edit Quiz.\n" +
                    "2 - Answer Quiz.\n" +
                    "0 - Exit.");

                userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Enter Question: \n");
                        q = Console.ReadLine();
                        Console.WriteLine("Enter Answer: \n");
                        a = Console.ReadLine();
                        QuizModel tempModel = new QuizModel(q, a);
                        XMLService? myService = new XMLService("quiz.xml");
                        myService.CreateNodeFromModel<QuizModel>(tempModel);
                        break;

                    case 2:
                        XElement quizDoc = XElement.Load("quiz.xml");
                        foreach ()

                        break;
                        
                }
            }



        }
    }
}
