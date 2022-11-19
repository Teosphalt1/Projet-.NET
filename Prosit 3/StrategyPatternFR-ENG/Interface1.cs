using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternFR_ENG
{
    public interface IStrategy
    {
        void DoAlgorithm();
        void ExecuteASave();
        void AddASave();
        void ExecuteOnAllTheSaves();
        void ExecuteOnASpecificSave();
        void AllSaveComplete();
        void AllSaveDifferential();
        void SpecificSaveComplete();
        void SpecificSaveDifferential();
    }
}
