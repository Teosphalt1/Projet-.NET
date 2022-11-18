using s;
using v;


namespace c
{
    internal class Controller
    {
        Service s;

        public Controller(Service s)
        {
            this.s = s;
        }
        internal string convert (string? chaine)
        {
            if(!valid(chaine))
            {
                throw new ExceptionConvertString();
            }
            return s.Up(chaine);
        }

        internal bool valid(string? chaine)
        {
            if (chaine.Length >= 1 && chaine.Length <= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
