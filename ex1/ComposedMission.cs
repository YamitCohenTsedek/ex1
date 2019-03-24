using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private string name;

        private String type = "Composed";

        public event EventHandler<double> OnCalculate;

        private List<Calc> functions = new List<Calc>();

        public ComposedMission(string missionName)
        {
            name = missionName;
        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
        }

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

            if (OnCalculate != null)
            {
                OnCalculate.Invoke(this, currentValue);
            }
            return currentValue;
        }

    }
}
