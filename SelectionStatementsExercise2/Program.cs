using System.Diagnostics.Metrics;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("What was your favorite subject in school?");
            string subject = Console.ReadLine();

            switch(subject)
            {
                case "English":
                case "english":
                    Console.WriteLine("English is fun.");
                    break;
                case "Math":
                case "math":
                    Console.WriteLine("Math is fun. I am not great with numbers");
                    break;
                case "Science":
                case "science":
                        Console.WriteLine("I could never get into science");
                    break;
                case "Physical education":
                case "PE":
                        Console.WriteLine("I love PE!");
                    break;
                case "History":
                case "history":
                    Console.WriteLine("History is great!");
                    break;

                default: Console.WriteLine("That's a school subject?! Never had that");
                    break;


            }
        }
    }
}