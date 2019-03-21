using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise_1
{
    public delegate double Calc(double value);

    class FunctionsContainer
    {
        Dictionary<string, Calc> functions = new Dictionary<string, Calc>();

        public List<string> getAllMissions()
        {
            return functions.Keys.ToList();
        }

        public Calc this[string key]
        {
            get
            {
                foreach (string funcName in functions.Keys)
                {
                    if (funcName == key)
                    {
                        return functions[funcName];
                    }
                }
                functions.Add(key, val => val);
                return val => val;
            }
            set
            {
                functions[key] = value;
            }
        }
    }
}
