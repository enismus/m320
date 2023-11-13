using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser_Simulator
{
    public class Simulator
    {
        public void Start()
        {
            while (true)
            {
                Console.Write("Geben Sie eine URL ein (oder 'exit' zum Beenden): ");
                string userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    break;
                }

                NavigateToPage(userInput);
            }
        }

        public void NavigateToPage(string url)
        {
            Console.WriteLine($"Lade URL: {url}");
            // Hier könnten Sie die tatsächliche Navigation zur URL hinzufügen.
        }
    }
}
