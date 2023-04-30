using dblabaaa2;

public static class Program
{
    public static void Main()
    {
        var histories = new List<History>();
        var books = new List<Book>();
        var customers = new List<Customer>();
        var properties = Json.ReadJson(@"C:\Users\Dell\source\repos\laba2\laba2\structure.json");

        var filetester = new FileTester();
        if (filetester.Test(@"C:\Users\Dell\source\repos\laba2\laba2\structure.json"))
        {
            foreach (var (table, metadata) in properties)
            {
                var data = FileTester.ReadFileData(table);
                foreach (var row in data)
                {
                    if (row.Count == 5)
                        books.Add(new Book(row));
                    else if (row.Count == 2)
                        customers.Add(new Customer(row));
                    else
                        histories.Add(new History(row));
                }
            }
        }

        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
        foreach (var customer in customers)
        {
            Console.WriteLine(customer);
        }
        foreach (var history in histories)
        {
            Console.WriteLine(history);
        }
    }

}