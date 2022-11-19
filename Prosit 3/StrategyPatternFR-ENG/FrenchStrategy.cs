using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternFR_ENG
{
    class FrenchStrategy : IStrategy
    {
        string saveName;
        public void DoAlgorithm()
        {
            Console.WriteLine("1-Executer un travail de sauvegarde\n2-Ajouter une sauvegarde");
        }

        public void ExecuteASave()
        {
            Console.WriteLine("1-Executer la sauvegarde sur tous les traveaux\n2-Executer sur un travail");
        }

        public void AddASave()
        {
            Console.WriteLine("Vous avez ajouté une nouvelle sauvegarde");
        }

        public void ExecuteOnAllTheSaves()
        {
            Console.WriteLine("1-Executer une sauvegarde complète\n2-Executer une sauvegarde différentielle");
        }
        public void ExecuteOnASpecificSave()
        {
            Console.WriteLine("Donnez le nom exact de la sauvegarde");
            saveName = Console.ReadLine();
            Console.WriteLine("1-Executer une sauvegarde complète\n2-Executer une sauvegarde différentielle");
        }

        public void AllSaveComplete()
        {
            Console.WriteLine("Vous avez fait une sauvegarde complète de tous les traveaux de sauvegarde");
        }

        public void AllSaveDifferential()
        {
            Console.WriteLine("Vous avez fait une sauvegarde différentielle de tous les traveaux de sauvegarde");
        }

        public void SpecificSaveComplete()
        {
            Console.WriteLine("Vous avez fait une sauvegarde complète de la sauvegarde " + saveName);
        }

        public void SpecificSaveDifferential()
        {
            Console.WriteLine("Vous avez fait une sauvegarde différentielle de la sauvegarde " + saveName);
        }
    }
}
