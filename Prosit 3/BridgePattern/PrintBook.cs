//using BridgePattern.BookContentProviders;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BridgePattern
//{
//    public /*abstract*/ class PrintBook : IBook
//    {
//        public void Publish()
//        {
//            //IEnumerable<string> bookContent = GetBookContent();
//            IEnumerable<string> bookContent = _contentProvider.GetContent();

//            //Console.WriteLine($"Successfully printed book. (${bookContent.Count()} lines)");

//            Console.WriteLine("Saved boook content to database");
//        }

//        private readonly IBookContentProvider _contentProvider;

//        public PrintBook(IBookContentProvider contentProvider)
//        {
//            _contentProvider = contentProvider;
//        }

//        //protected abstract IEnumerable<string> GetBookContent();
//    }
//}
