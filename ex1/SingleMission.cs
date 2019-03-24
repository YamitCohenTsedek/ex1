using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        // a member that will save the name of the Calc function
        private string funcName;

        // setting the delegate from type Calc as a member
        private Calc calcFunc;

        public event EventHandler<double> OnCalculate;

        // constructor
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

        public string Type { get; } = "Single";

        public double Calculate(double value)
        {
            double currentValue = calcFunc(value);

            // invoke the event handler only if it's not null
            if (OnCalculate != null)
            {
                OnCalculate.Invoke(this, currentValue);
            }
            return currentValue;
        }

    }
}
