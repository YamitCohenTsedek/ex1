using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private string funcName;

        private Calc calcFunc;

        private String type = "Single";

        public event EventHandler<double> OnCalculate;

        public string Type
        {
            get;
        }

        public SingleMission(Calc func, string name)
        {
            calcFunc = func;
            funcName = name;
        }

        public string Name
        {
            get
            {
                return funcName;
            }
            private set
            {
                funcName = value;
            }
        }

        public double Calculate(double value)
        {
            double currentValue = calcFunc(value);
            if (OnCalculate != null)
            {
                OnCalculate.Invoke(this, currentValue);
            }
            return currentValue;
        }

    }
}
