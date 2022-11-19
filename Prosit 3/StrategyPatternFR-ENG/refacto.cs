//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StrategyPatternFR_ENG2
//{
//    class Context
//    {
//        private IStrategy _strategy;

//        //public Context() { }

//        //public Context(IStrategy strategy)
//        //{
//        //    _strategy = strategy;
//        //}

//        public void SetStrategy(IStrategy strategy)
//        {
//            _strategy = strategy;
//        }

//        public void DoSomeBusinessLogic()
//        {
//            this._strategy.DoAlgorithm();
//            string choice = Console.ReadLine();
//            if (choice == "1")
//            {
//                this._strategy.ExecuteASave();
//                string choiceNumberOfSave = Console.ReadLine();
//                if (choiceNumberOfSave == "1")
//                {
//                    this._strategy.ExecuteOnAllTheSaves();
//                    string choiceType = Console.ReadLine();
                    
//                    if (choiceType == "1")
//                    {
//                        this._strategy.AllSaveComplete();
//                    }
//                    if (choiceType == "2")
//                    {
//                        this._strategy.AllSaveDifferential();
//                    }
//                }
//                if (choiceNumberOfSave == "2")
//                {
//                    this._strategy.ExecuteOnASpecificSave();
//                    string choiceType = Console.ReadLine();
//                    if (choiceType == "1")
//                    {
//                        this._strategy.SpecificSaveComplete();
//                    }
//                    if (choiceType == "2")
//                    {
//                        this._strategy.SpecificSaveDifferential();
//                    }
//                }
//            }
//            if (choice == "2")
//            {
//                this._strategy.AddASave();
//            }
//            else { }
//        }
//    }

//    public interface IStrategy
//    {
//        void DoAlgorithm();
//        void ExecuteASave();
//        void AddASave();
//        void ExecuteOnAllTheSaves();
//        void ExecuteOnASpecificSave();
//        void AllSaveComplete();
//        void AllSaveDifferential();
//        void SpecificSaveComplete();
//        void SpecificSaveDifferential();
//    }

//    class FrenchStrategy : IStrategy
//    {
//        string saveName;
//        public void DoAlgorithm()
//        {
//            Console.WriteLine("1-Executer un travail de sauvegarde\n2-Ajouter une sauvegarde");
//        }

//        public void ExecuteASave()
//        {
//            Console.WriteLine("1-Executer la sauvegarde sur tous les traveaux\n2-Executer sur un travail");
//        }

//        public void AddASave()
//        {
//            Console.WriteLine("Vous avez ajouté une nouvelle sauvegarde");
//        }

//        public void ExecuteOnAllTheSaves()
//        {
//            Console.WriteLine("1-Executer une sauvegarde complète\n2-Executer une sauvegarde différentielle");
//        }
//        public void ExecuteOnASpecificSave()
//        {
//            Console.WriteLine("Donnez le nom exact de la sauvegarde");
//            saveName = Console.ReadLine();
//            Console.WriteLine("1-Executer une sauvegarde complète\n2-Executer une sauvegarde différentielle");
//        }

//        public void AllSaveComplete()
//        {
//            Console.WriteLine("Vous avez fait une sauvegarde complète de tous les traveaux de sauvegarde");
//        }

//        public void AllSaveDifferential()
//        {
//            Console.WriteLine("Vous avez fait une sauvegarde différentielle de tous les traveaux de sauvegarde");
//        }

//        public void SpecificSaveComplete()
//        {
//            Console.WriteLine("Vous avez fait une sauvegarde complète de la sauvegarde "+saveName);
//        }

//        public void SpecificSaveDifferential()
//        {
//            Console.WriteLine("Vous avez fait une sauvegarde différentielle de la sauvegarde "+saveName);
//        }
//    }

//    class EnglishStrategy : IStrategy
//    {
//        string saveName;
//        public void DoAlgorithm()
//        {
//            Console.WriteLine("1-Execute a save\n2-Add a save");
//        }

//        public void ExecuteASave()
//        {
//            Console.WriteLine("1-Execute on all the saves\n2-Execute on a particular save");
//        }
//        public void AddASave()
//        {
//            Console.WriteLine("You've added a new save");
//        }

//        public void ExecuteOnAllTheSaves()
//        {
//            Console.WriteLine("1-Execute a complete save\n2-Execute a differential save");
//        }

//        public void ExecuteOnASpecificSave()
//        {
//            Console.WriteLine("Give the exact name of the save");
//            saveName = Console.ReadLine();
//            Console.WriteLine("1-Execute a complete save\n2-Execute a differential save");
//        }

//        public void AllSaveComplete()
//        {
//            Console.WriteLine("You have done a complete save of every save work");
//        }
//        public void AllSaveDifferential()
//        {
//            Console.WriteLine("You have done a differential save of every save work");
//        }

//        public void SpecificSaveComplete()
//        {
//            Console.WriteLine("You have done a complete save of the save work "+saveName);
//        }

//        public void SpecificSaveDifferential()
//        {
//            Console.WriteLine("You have done a differential save of the save work "+saveName);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var context = new Context();
//            void selectLanguage()
//            {
//                Console.WriteLine("Tapez FR pour avoir le software en francais or EN to have the english version of the software");
//                string language = Console.ReadLine();
//                Console.WriteLine(language);
//                if (language == "FR" || language == "fr")
//                {
//                    context.SetStrategy(new FrenchStrategy());
//                    context.DoSomeBusinessLogic();
//                }
//                if (language == "EN" || language == "en")
//                {
//                    context.SetStrategy(new EnglishStrategy());
//                    context.DoSomeBusinessLogic();
//                }
//                else
//                {
//                    Console.WriteLine("Error");
//                }
//            }
//            while (true)
//            {
//                selectLanguage();
//            }
//        }
//    }
//}
