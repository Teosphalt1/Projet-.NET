using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternFR_ENG
{
    class EnglishStrategy : IStrategy
    {
        string saveName;
        public void DoAlgorithm()
        {
            Console.WriteLine("1-Execute a save\n2-Add a save");
        }

        public void ExecuteASave()
        {
            Console.WriteLine("1-Execute on all the saves\n2-Execute on a particular save");
        }
        public void AddASave()
        {
            Console.WriteLine("You've added a new save");
        }

        public void ExecuteOnAllTheSaves()
        {
            Console.WriteLine("1-Execute a complete save\n2-Execute a differential save");
        }

        public void ExecuteOnASpecificSave()
        {
            Console.WriteLine("Give the exact name of the save");
            saveName = Console.ReadLine();
            Console.WriteLine("1-Execute a complete save\n2-Execute a differential save");
        }

        public void AllSaveComplete()
        {
            Console.WriteLine("You have done a complete save of every save work");
        }
        public void AllSaveDifferential()
        {
            Console.WriteLine("You have done a differential save of every save work");
        }

        public void SpecificSaveComplete()
        {
            Console.WriteLine("You have done a complete save of the save work " + saveName);
        }

        public void SpecificSaveDifferential()
        {
            Console.WriteLine("You have done a differential save of the save work " + saveName);
        }
    }
}
