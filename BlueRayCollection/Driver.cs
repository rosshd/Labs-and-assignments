using System;
using System.Collections.Generic;

class BlueRayDisc
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int YearOfRelease { get; set; }
    public double Cost { get; set; }

    public BlueRayDisc(string title, string director, int yearOfRelease, double cost)
    {
        Title = title;
        Director = director;
        YearOfRelease = yearOfRelease;
        Cost = cost;
    }

    public override string ToString()
    {
        return $"${Cost} {YearOfRelease} {Title}, {Director}";
    }
}

class Node {
    public BlueRayDisc data;
    public Node next;

    public Node(BlueRayDisc data) {
        this.data = data;
        this.next = null;
    }
}

class BlueRayCollection {
    private Node head;

    public BlueRayCollection() {
        head = null;
    }

    public void add(string title, string director, int year, double cost) {
        BlueRayDisc newDisk = new BlueRayDisc(title, director, year, cost);
        Node newNode = new Node(newDisk);
        newNode.next = head;
        head = newNode;
    }

    public void show_all() {
        Node current = head;
        while (current != null) {
            Console.WriteLine(current.data.ToString());
            current = current.next;
        }
    }
}

class Driver
{
    static void Main(string[] args)
    {
        var collection = new BlueRayCollection();

        int choice = -1;
        while (choice != 0)
        {
            Console.WriteLine("0. Quit");
            Console.WriteLine("1. Add BlueRay to collection");
            Console.WriteLine("2. See collection");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("What is the title? ");
                    string title = Console.ReadLine();
                    Console.WriteLine("Who is the director? ");
                    string director = Console.ReadLine();
                    Console.WriteLine("What is the year of release? ");
                    int yearOfRelease = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("What is the cost? ");
                    double cost = Double.Parse(Console.ReadLine());

                    collection.add(title, director, yearOfRelease, cost);
                    break;
                case 2:
                    collection.show_all();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}