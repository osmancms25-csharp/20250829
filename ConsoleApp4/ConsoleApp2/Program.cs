List<string> name_list = [];



Console.Clear();

Console.WriteLine("### NAMNLISTA ###");

foreach (string name in name_list)
{
    Console.WriteLine(name);
}


Console.ReadKey();


string answer = "";
do
{
    Console.WriteLine("Hej och välkommen");
    Console.Write("Ange ett namn: ");

    string input_name = Console.ReadLine()!;

    if (!string.IsNullOrEmpty(input_name))
    {
        name_list.Add(input_name);
    }
    Console.Write("Vill du ange ett nytt namna? (y/n): ");
    answer = Console.ReadLine() !;

}
while (answer == "y");

{

}
