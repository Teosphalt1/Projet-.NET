namespace DifferentialSave
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("indiquez le chemin d'accès au dossier");
            string sourcePath = @"C:\Users\teosp\OneDrive\Bureau\A3\ici";
            string targetPath = @"C:\Users\teosp\OneDrive\Bureau\A3\la";

            CopyFilesRecursively(sourcePath, targetPath);
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
                        DateTime lastModifiedTime = File.GetLastWriteTime(newPath);
                        DateTime Test = Convert.ToDateTime("21 / 11 / 2022 14:05:33"); //Remplacer la string date par celle récupérée dans le file JSON
                        int compareDateTime = DateTime.Compare(lastModifiedTime, Test);
                        if (compareDateTime > 0)
                        {
                            File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                        }
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