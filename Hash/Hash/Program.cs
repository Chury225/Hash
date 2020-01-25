using System;
using System.Collections;

public class TestClass
{

    public static void Main()
    {

        Hashtable ht = new Hashtable();

        // Usando Add()
        ht.Add("A", "apple"); ht.Add("D", "durian");
        ht.Add("B", "banana"); ht.Add("C", "coconut");
        PrintCollection(ht);

        // Usando la propiedad Count
        Console.WriteLine("Count: {0}\n", ht.Count);

        // Usando ContainsKey()
        Console.WriteLine(ht.ContainsKey("D"));
        Console.WriteLine(ht.ContainsKey("S") + "\n");

        // Usando ContainsValue()
        Console.WriteLine(ht.ContainsValue("banana"));
        Console.WriteLine(ht.ContainsValue("starfruit") + "\n");

        // Usando Remove()
        ht.Remove("B");
        PrintCollection(ht);

        // Usando la propiedad Keys
        foreach (string key in ht.Keys)
            Console.WriteLine(key);

        // Usando la propiedad Values()
        Console.WriteLine();
        foreach (string val in ht.Values)
            Console.WriteLine(val);
    }

    public static void PrintCollection(IEnumerable myCollection)
    {
        foreach (DictionaryEntry de in myCollection)
            Console.WriteLine("Key: {0} Value: {1}", de.Key, de.Value);
    }

}
