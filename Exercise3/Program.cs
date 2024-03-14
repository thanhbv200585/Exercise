using Exercise3;
using System;
using System.IO;
public class Program
{
    public static void Main()
    {
        ContestManager contestManager = new();
        contestManager.AddContestant(new Contestant(1, "Thanh", "Dinh Cong", 1, "A"));
        contestManager.AddContestant(new Contestant(2, "Linh", "Dinh Cong", 1, "A"));
        contestManager.AddContestant(new Contestant(3, "Nhung", "Dinh Cong", 1, "B"));
        contestManager.AddContestant(new Contestant(4, "Ngan", "Dinh Cong", 1, "C"));
        contestManager.AddContestant(new Contestant(1, "Phuong", "Dinh Cong", 1, "A"));


        Console.WriteLine("All contestants: ");
        contestManager.DisplayAllContestant();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("All contestants whose id is 1: ");
        contestManager.SearchById(1);

    }
}