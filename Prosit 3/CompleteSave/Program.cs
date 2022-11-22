namespace CompleteSave
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("indiquez le chemin d'accès au dossier");
            string sourcePath = Console.ReadLine();

            Console.WriteLine("indiquez le chemin de destination du dossier");
            string targetPath = Console.ReadLine();
            CopyFilesRecursively(sourcePath, targetPath);

            Console.WriteLine(sourcePath + " a bien été sauvegardé au niveau de " + targetPath);
        }
        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            try
                {
                foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                }
                try
                {
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                    {
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                    }
                }
                catch
                {
                    Console.WriteLine("nope marche pas car destination pas bonne");
                }
            }
            catch
            {
                Console.WriteLine("nope marche pas car source pas bonne");
            }  
        }

    }
}