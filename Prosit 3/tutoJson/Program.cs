using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace cs_load_json
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                Console.WriteLine("1-Afficher les sauvegardes existantes\n2-Ajouter une nouvelle sauvegarde");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    convert_json_to_cs();
                }
                if (choice == "2")
                {
                    CreateSaveWork();
                }
            }
            
        }

        static SaveWork convert_json_to_cs()
        {
            string fileName = @"c:\bdd.json";

            if (System.IO.File.Exists(fileName))
            {
                string justText = File.ReadAllText(fileName);
                var myPosts = JsonConvert.DeserializeObject<SaveWork[]>(justText);

                foreach (var post in myPosts)
                {
                    Console.WriteLine($"{post.id} {post.Name} {post.FileSource} {post.destPath} {post.time}");
                }
            }
            return (null);
        }

        static SaveWork CreateSaveWork()
        {
            string fileName = @"c:\bdd.json";

            string justText = File.ReadAllText(fileName);
            List<SaveWork> myPosts = JsonConvert.DeserializeObject<List<SaveWork>>(justText);
            SaveWork sw = new SaveWork();
            int count = myPosts.Count;
            sw.id = count + 1;
            Console.WriteLine("nom");
            sw.Name = Console.ReadLine();
            Console.WriteLine("source");
            sw.FileSource = Console.ReadLine();
            Console.WriteLine("destination");
            sw.destPath = Console.ReadLine();
            sw.time = DateTime.Now.ToString();

            myPosts.Add(sw);

            string json = System.Text.Json.JsonSerializer.Serialize(myPosts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileName, json);

            return(sw);
        }
    }
}