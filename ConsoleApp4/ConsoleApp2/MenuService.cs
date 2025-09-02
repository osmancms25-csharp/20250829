
namespace ConsoleApp2
{
    internal static class MenuService
    {
        private static List<string> name_list = new List<string>();

        public static void DisplayListView(List<string> list)
        {
            Console.Clear();
            Console.WriteLine("View Name List");
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }

        public static void AddNameToList(List<string> list)
        {
            Console.WriteLine("--- Add to List ---");
            Console.Write("Enter name: ");
            string input_name = Console.ReadLine()!;

            if (!string.IsNullOrWhiteSpace(input_name))
            {
                list.Add(input_name);
            }
        }

        public static void DisplayMenuOptions()
        {
            while (true)
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
                        DisplayListView(name_list);
                        break;

                    case "2":
                        AddNameToList(name_list);
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        
                        break;
                }
            }
        }
    }
}
