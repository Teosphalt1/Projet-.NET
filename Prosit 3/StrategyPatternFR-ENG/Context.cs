using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternFR_ENG
{
    class Context
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            this._strategy.DoAlgorithm();
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                this._strategy.ExecuteASave();
                string choiceNumberOfSave = Console.ReadLine();
                if (choiceNumberOfSave == "1")
                {
                    this._strategy.ExecuteOnAllTheSaves();
                    string choiceType = Console.ReadLine();

                    if (choiceType == "1")
                    {
                        this._strategy.AllSaveComplete();
                    }
                    if (choiceType == "2")
                    {
                        this._strategy.AllSaveDifferential();
                    }
                }
                if (choiceNumberOfSave == "2")
                {
                    this._strategy.ExecuteOnASpecificSave();
                    string choiceType = Console.ReadLine();
                    if (choiceType == "1")
                    {
                        this._strategy.SpecificSaveComplete();
                    }
                    if (choiceType == "2")
                    {
                        this._strategy.SpecificSaveDifferential();
                    }
                }
            }
            if (choice == "2")
            {
                this._strategy.AddASave();
            }
            else { }
        }
    }
}
