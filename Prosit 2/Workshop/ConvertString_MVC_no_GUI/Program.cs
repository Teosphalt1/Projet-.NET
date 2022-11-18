using c;
using v;
using s;

class Program
{
    static void Main(string[] args)
    {
        Service s = new Service();
        Controller c = new Controller(s);
        View v = new View(c);

        v.user_input();
    }
}