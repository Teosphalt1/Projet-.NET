//using System;
//using System.Collections.Generic;

//namespace StrategyPatternFR_ENG
//{
//    class Context
//    {
//        private IStrategy _strategy;

//        public Context() { }

//        public Context(IStrategy strategy)
//        {
//            _strategy = strategy;
//        }

//        public void SetStrategy(IStrategy strategy)
//        {
//            _strategy = strategy;
//        }

//        public void DoSomeBusinessLogic()
//        {
//            var result = this._strategy.DoAlgorithm(new List<string> { "1-Bonjour", "2-Par ici" });

//            string resultStr = string.Empty;
//            foreach (var element in result as List<string>)
//            {
//                resultStr += element + ",";
//            }

//            Console.WriteLine(resultStr);
//        }
//    }
//    public interface IStrategy
//    {
//        object DoAlgorithm(object data);
//    }

//    class ConcreteStrategyA : IStrategy
//    {
//        public object DoAlgorithm(object data)
//        {
//            var list = data as List<string>;
//            list.Sort();

//            return list;
//        }
//    }

//    class ConcreteStrategyB : IStrategy
//    {
//        public object DoAlgorithm(object data)
//        {
//            var list = data as List<string>;
//            list.Sort();
//            list[0] = "1-Hello";
//            list[1] = "2-Right Here";

//            return list;
//        }
//    }

//    //class Program
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        var context = new Context();
//    //        void selectLanguage()
//    //        {
//    //            Console.WriteLine("Tapez FR pour avoir le software en francais or EN to have the english version of the software");
//    //            string language = Console.ReadLine();
//    //            if(language == "FR" || language == "fr")
//    //            {
//    //                context.SetStrategy(new ConcreteStrategyA());
//    //                context.DoSomeBusinessLogic();
//    //            }
//    //            if (language == "EN" || language == "en")
//    //            {
//    //                context.SetStrategy(new ConcreteStrategyB());
//    //                context.DoSomeBusinessLogic();
//    //            }
//    //            else
//    //            {
//    //                Console.WriteLine("Error");
//    //            }
//    //        }
//    //        while(true)
//    //        {
//    //            selectLanguage();
//    //        }
//    //        // The client code picks a concrete strategy and passes it to the
//    //        // context. The client should be aware of the differences between
//    //        // strategies in order to make the right choice.


//    //        //var context = new Context();

//    //        //Console.WriteLine("Client: Strategy is set to normal sorting.");
//    //        //context.SetStrategy(new ConcreteStrategyA());
//    //        //context.DoSomeBusinessLogic();

//    //        //Console.WriteLine();

//    //        //Console.WriteLine("Client: Strategy is set to reverse sorting.");
//    //        //context.SetStrategy(new ConcreteStrategyB());
//    //        //context.DoSomeBusinessLogic();
//    //    }
//    //}

//}