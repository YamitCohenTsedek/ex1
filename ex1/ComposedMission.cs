using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        // a member that will save the name of the Calc function
        private string funcName;

        public event EventHandler<double> OnCalculate;

        // setting a list of delegates from type Calc as a member
        private List<Calc> functions = new List<Calc>();

        // constructor
        public ComposedMission(string missionName)
        {
            funcName = missionName;
        }


        public string Name
        {
            get
            {
                return funcName;
            }
            set
            {
                funcName = value;
            }
        }

        public string Type { get; } = "Composed";

        public ComposedMission Add(Calc function)
        {
            functions.Add(function);
            return this;
        }

        public double Calculate(double value)
        {
            //initialize currentValue with the given value
            double currentValue = value;

            foreach (Calc function in functions)
            {
                currentValue = function(currentValue);
            }

            // invoke the event handler only if it's not null
            if (OnCalculate != null)
            {
                OnCalculate.Invoke(this, currentValue);
            }
            return currentValue;
        }

    }
}
