using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise_1
{
    public delegate double Calc(double value);

    class FunctionsContainer
    {
        // a dictionary that maps a name of a function to the delegate from type Calc
        Dictionary<string, Calc> functions = new Dictionary<string, Calc>();

        // return all the existing missions
        public List<string> getAllMissions()
        {
            return functions.Keys.ToList();
        }

        // implementation of [] opearator
        public Calc this[string key]
        {
            get
            {
                // running over the names of the functions
                foreach (string funcName in functions.Keys)
                {
                    if (funcName == key)
                    {
                        return functions[funcName];
                    }
                }
                // if the function doesn't exist, add the function to the functions dictionary
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
