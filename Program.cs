using System;
using System.Collections.Generic;

namespace CollectionsAndStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> is a generic type, a type that requires me to tell it what type of stuff it holds/does
            // In this case, `string` is a type parameter that tells 
            var names = new List<string>();

            // Add a single item
            // Works like .push(), appends to the end of the list
            names.Add("Sean");
            names.Add("Matt");
            names.Add("John");

            // Puts the item at a certain index in a list, similar to splice
            names.Insert(1, "Aaron");

            // Collection initializer - curly braces with elements inside
            var otherNames = new List<string> { "Nick", "Blaze", "Josh" };

            // Add on collection to another
            names.AddRange(otherNames);

            // How to remove something from a list (uses reference equality) 
            // Can remove a specific item
            names.Remove("Sean");

            // Removes at a given index
            names.RemoveAt(0);

            // Removes by expression
            names.RemoveAll(names => names.StartsWith("N"));    

            // Loops over collection
            names.ForEach(name => Console.WriteLine(name));


            
            // Dictionary<TKey, TValue> ----> Open generic (not specified what type of thing it is yet)
            // Like a physical dictionary, keys must be unique
            var dictionary = new Dictionary<string, string>(); // Closed generic (we have told it how to behave)

            dictionary.Add("Penultimate", "Second to last");
            dictionary.Add("Jib", "Things that stick out of roller coasters");
            dictionary.Add("Arbitrary", "Based on random choice");

            // Get one thing based on its key
            var definition = dictionary["Arbitrary"];

            // .TryAdd() returns true if can add, false if cannot add 
            if (!dictionary.TryAdd("Penultimate", "Again")) 
            {
                Console.WriteLine("It's already in the dictionary.");
            }

            if (dictionary.ContainsKey("Jib"))
            {
                Console.WriteLine("You already have this");
            }
            
            // Give me all of the keys in a collection
            var allTheWords = dictionary.Keys;

            foreach (var (word, def) in dictionary)
            {
                Console.WriteLine($"{word} - {def}");
            }
        }
    }
}
