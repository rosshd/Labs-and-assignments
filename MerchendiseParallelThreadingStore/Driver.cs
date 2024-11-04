using System;
using System.Threading;

public class Merchandise
{
    public string merchandise;
    public Merchandise next;

    public Merchandise(string merchandise)
    {
        this.merchandise = merchandise;
        this.next = null;
    }
}

public class MerchandiseStorage
{
    private Merchandise top;
    private readonly object lockObject = new object();

    public void addMerchandise(string merchandise)
    {
        Merchandise newMerchandise = new Merchandise(merchandise);
        newMerchandise.next = top;
        top = newMerchandise;
    }

    public string retrieveMerchandise()
    {
        lock (lockObject)
        {
            if (top == null)
            {
                return "";
            }
            else
            {
                string merchandise = top.merchandise;
                top = top.next;
                return merchandise;
            }
        }
    }
}

public class Store
{
    private static readonly object lockObject = new object();
    private static decimal totalRevenue;
    private static int itemsSold;
    private MerchandiseStorage pile;

    public Store(MerchandiseStorage pile)
    {
        this.pile = pile;
    }

    public static decimal TotalRevenue
    {
        get
        {
            lock (lockObject)
            {
                return totalRevenue;
            }
        }
    }

    public static int ItemsSold
    {
        get
        {
            lock (lockObject)
            {
                return itemsSold;
            }
        }
    }

    public void run()
    {
        while (true)
        {
            string merchandise = pile.retrieveMerchandise();
            if (string.IsNullOrEmpty(merchandise))
            {
                break;
            }

            decimal price = GetPrice(merchandise);
            lock (lockObject)
            {
                totalRevenue += price;
                itemsSold++;
            }
        }

        Console.WriteLine($"{Thread.CurrentThread.Name} is done selling.");
    }

    private decimal GetPrice(string merchandise)
    {
        switch (merchandise)
        {
            case "keychain":
                return 5;
            case "t-shirt":
                return 30;
            case "plush":
                return 50;
            default:
                return 0;
        }
    }
}

public class Driver
{
    public static void Main()
    {
        Console.WriteLine("[Store Management System]");
        
        MerchandiseStorage merchandiseStorage = new MerchandiseStorage();

        Console.Write("How many keychains are being sold? ");
        int keychainCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < keychainCount; i++)
        {
            merchandiseStorage.addMerchandise("keychain");
        }

        Console.Write("How many t-shirts are being sold? ");
        int tshirtCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < tshirtCount; i++)
        {
            merchandiseStorage.addMerchandise("t-shirt");
        }

        Console.Write("How many plushies are being sold? ");
        int plushCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < plushCount; i++)
        {
            merchandiseStorage.addMerchandise("plush");
        }

        Console.Write("Storage has been stocked. Press any key to start selling...");
        Console.ReadKey();
        Console.WriteLine("\n");

        Store store1 = new Store(merchandiseStorage);
        Store store2 = new Store(merchandiseStorage);
        Store store3 = new Store(merchandiseStorage);

        Thread thread1 = new Thread(store1.run) { Name = "Store 1" };
        Thread thread2 = new Thread(store2.run) { Name = "Store 2" };
        Thread thread3 = new Thread(store3.run) { Name = "Store 3" };

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine($"\nTotal revenue: ${Store.TotalRevenue}");
        Console.WriteLine($"Number of items sold: {Store.ItemsSold}");
        Console.WriteLine("The show was a success!");
    }
}