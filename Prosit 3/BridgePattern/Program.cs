using BridgePattern.BookContentProviders;
using BridgePattern.BookPublishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //AutobiographyAudioBook book = new AutobiographyAudioBook();
            //AutobiographyPrintBook book1 = new AutobiographyPrintBook();
            //book.Publish();
            //book1.Publish();

            //===================================================================

            //IBookContentProvider contentProvider = new AutobiographyBookContentProvider();
            //IBookContentProvider contentProvider1 = new SCIFIBookContentProvider();

            //PrintBook AutoBiogrpahyPrintBook = new PrintBook(contentProvider);
            //AutoBiogrpahyPrintBook.Publish();

            //DigitalBook AutoBiogrpahyDigitalBook = new DigitalBook(contentProvider);
            //AutoBiogrpahyDigitalBook.Publish();

            //PrintBook SCIFIPrintBook = new PrintBook(contentProvider1);
            //SCIFIPrintBook.Publish();

            //===================================================================

            IBookContentProvider contentProvider = new SCIFIBookContentProvider();
            IBookPublisher publisher = new AudioBookPublisher();
            Book book = new Book(contentProvider, publisher);
            book.Publish();

            Console.ReadKey();
        }
    }
}
