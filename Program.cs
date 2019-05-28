using System;
using System.Collections.Generic;

namespace Family_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Krista"},
                {"age", "42"}
});
            myFamily.Add("mom", new Dictionary<string, string>(){
                {"name", "Rebecca"},
                {"age", "70"}
});
            myFamily.Add("dad", new Dictionary<string, string>(){
                {"name", "Jon"},
                {"age", "71"}
});

            foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
        {
            Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old. ");
}
        }
        }
    }

