//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
//      .NET – platform for applications from Microsoft
//      CLR – managed execution environment for .NET
//      namespace – hierarchical organization of classes

using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    struct Dict
    {
        string key;
        string value;

        public Dict(string key, string value)
        {
            this.key = key;
            this.value = value;
        }

        public string Key
        {
            get
            {
                return this.key;
            }
            set
            {
                this.key = value;
            }
        }

        public string Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
    }

    static void Main()
    {
        string[] inputs = { ".NET - platform for applications from Microsoft",
                            "namespace - hierarchical organization of classes",
                            "CLR - managed execution environment for .NET",
                              "Java - object-oriented programming language, similar to C#",
                              "JavaScript - web programming language" };

        List<Dict> dictionary = new List<Dict>();

        int separator;
        string key;
        string value;

        for (int i = 0; i < inputs.Length; i++)
        {
            separator = inputs[i].IndexOf('-');

            key = (inputs[i].Substring(0, separator).Trim());

            value = inputs[i].Substring(separator + 1).Trim();

            dictionary.Add(new Dict(key, value));
        }

        Console.WriteLine("Enter some word, like - \".NET\", \"CLR\", \"namespace\", \"Java\", \"JavaScript\"");
        string inputKey = Console.ReadLine();

        //dictionary = dictionary.OrderBy(x => x.Key).ToList();

        foreach (var dict in dictionary)
        {
            if (dict.Key.ToLower() == inputKey.ToLower())
            {
                Console.WriteLine("{0} - {1}", dict.Key, dict.Value);
            }
        }
    }
}