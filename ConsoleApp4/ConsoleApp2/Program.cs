List<string> name_list = [];

do
{
    Console.Clear();

    Console.WriteLine("--- MENU OPTIONS ---");
    Console.WriteLine("1. View List");
    Console.WriteLine("2. Add To List");
    Console.WriteLine("0. Exit Application");
    Console.WriteLine("");

    Console.Write("Choose one option: ");
    string option = Console.ReadLine()!;

    Console.Clear();

    switch (option)
    {
        case "1":
            Console.WriteLine("View List");
            foreach (string name in name_list)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
            break;

        case "2":
            Console.WriteLine("Add to List");
            Console.Write("Enter name: ");
            string input_name = Console.ReadLine()!;

            if ( !string.IsNullOrWhiteSpace(input_name))
            {
                name_list.Add(input_name);
            }
            break;

        case "0":
            Environment.Exit(0);
           
            break;

        default:
            break;
    }
    
    
}
    while (true) ;


