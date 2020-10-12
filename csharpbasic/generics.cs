using System.Collections.Generic;
using System;
namespace LearningClasses
{
    public class Generic
    {
        void learningList()
        {
            List<string> names = new List<string>();
            names.Add("sushant");
            names.Add("sushant");
            names.Add("sushant");
            names.Add("sushant");

            foreach(string name in names)
            {
                Console.WriteLine(name); 
            }
        }

        void LearningDictionary()
        {
            
        }


    }
}