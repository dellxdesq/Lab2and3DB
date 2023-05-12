using dblabaaa2;

public static class Program
{
    public static void Main()
    {
        var histories = new List<History>();
        var books = new List<Book>();
        var customers = new List<Customer>();
        var properties = Json.ReadJson(@"C:\Users\Dell\source\repos\dblabaaa2\dblabaaa2\structure.json");


        var filetester = new FileTester();
        if (filetester.Test(@"C:\Users\Dell\source\repos\laba2\laba2\structure.json"))
        {
            foreach (var (table, metadata) in properties)
            {
                var data = FileTester.ReadFileData(table);
                foreach (var row in data)
                {
                    if (table == "C:\\Users\\Dell\\Desktop\\Book.csv")
                        books.Add(new Book(row));
                    else if (table == "C:\\Users\\Dell\\Desktop\\Customer.csv")
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
        Console.WriteLine();
        foreach (var customer in customers)
        {
            Console.WriteLine(customer);
        }
        Console.WriteLine();
        TablePrinter.PrintTable(histories);


    }



}