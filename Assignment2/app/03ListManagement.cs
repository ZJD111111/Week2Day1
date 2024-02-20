namespace app1;
class ListManagements
{
    public void ListManagement()
    {
        List<string> itemList = new List<string>();

        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
            string input = Console.ReadLine();

            char command = input[0];
            string item = input.Substring(1).Trim();

            switch (command)
            {
                case '+':
                    if (!string.IsNullOrEmpty(item))
                    {
                        itemList.Add(item);
                    }
                    break;
                case '-':
                    if (!string.IsNullOrEmpty(item))
                    {
                        itemList.Remove(item);
                    }
                    else
                    {
                        itemList.Clear();
                    }
                    break;
            }

            Console.WriteLine("Current List:");
            foreach (string listItem in itemList)
            {
                Console.WriteLine(" " + listItem);
            }
        }
    }
}
