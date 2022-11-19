using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternFR_ENG
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            void selectLanguage()
            {
                Console.WriteLine("Tapez FR pour avoir le software en francais or EN to have the english version of the software");
                string language = Console.ReadLine();
                Console.WriteLine(language);
                if (language == "FR" || language == "fr")
                {
                    context.SetStrategy(new FrenchStrategy());
                    context.DoSomeBusinessLogic();
                }
                if (language == "EN" || language == "en")
                {
                    context.SetStrategy(new EnglishStrategy());
                    context.DoSomeBusinessLogic();
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            while (true)
            {
                selectLanguage();
            }
        }
    }
}
