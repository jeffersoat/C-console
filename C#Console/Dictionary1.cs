

using Microsoft.VisualBasic;

class Dictionary1
{
    public static void Dict1(string[] args)
    {
    Dictionary<string, string>Phonebook = new Dictionary<string, string>();
    Phonebook.Add("Ms.Levine", "756-760-9880");
    Phonebook.Add("Ms.Brooks", "760-756-9088");

    Console.WriteLine(Phonebook["Ms.Levine"]);
    }

    public static void Dict2(string[] args)
    {
        Dictionary<string, int>inventory = new Dictionary<string ,int>();
        inventory.Add("Apples", 50);
        inventory.Add("Bananas", 50);
        inventory.Add("Mango", 50);
        inventory.Add("Grapes", 50);

    foreach(KeyValuePair<string, int> item in inventory)
    {
        Console.WriteLine(item.Key + "" + item.Value)
    }
    }
}