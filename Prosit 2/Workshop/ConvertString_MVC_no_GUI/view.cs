using c;

namespace v
{
    internal class View
    {
        Controller c;

        public View(Controller c)
        {
            this.c = c;
        }

        public void user_input()
        {
            while(true)
            {
                string chaine = "";
                Console.WriteLine("1 to 8 chars");
                chaine = Console.ReadLine();

                try 
                {
                    //c.valid(chaine);
                    //Console.WriteLine(c.valid(chaine));
                    string chainconverti = c.convert(chaine);
                    Console.WriteLine(chainconverti);
                }
                catch {
                    Console.WriteLine("Marche pas");
                }
            }
            
        }
    }

}