using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount("Mia", 950);
        BankAccount account2 = new BankAccount("Noah", 120);
        BankAccount account3 = new BankAccount("Liam", 760);
        BankAccount account4 = new BankAccount("Ava", 1500);
        BankAccount account5 = new BankAccount("Ethan", 430);
        BankAccount account6 = new BankAccount("Sophia", 210);
        BankAccount account7 = new BankAccount("Lucas", 1100);
        BankAccount account8 = new BankAccount("Zoe", 680);
        BankAccount account9 = new BankAccount("Oliver", 50);
        BankAccount account10 = new BankAccount("Chloe", 890);

        SortedSet<BankAccount> accounts =
            new SortedSet<BankAccount>(new BankComparer());

        accounts.Add(account1);
        accounts.Add(account2);
        accounts.Add(account3);
        accounts.Add(account4);
        accounts.Add(account5);
        accounts.Add(account6);
        accounts.Add(account7);
        accounts.Add(account8);
        accounts.Add(account9);
        accounts.Add(account10);

        Console.WriteLine("Original Accounts:");
        DisplayAccounts(accounts);

        // Adding a new high balance account
        Console.WriteLine("\nAfter adding a new high account:");

        BankAccount highAccount =
            new BankAccount("Rashmeen", 5000);

        accounts.Add(highAccount);

        DisplayAccounts(accounts);

        // Trying to add a duplicate
        Console.WriteLine("\nAfter adding duplicate:");

        BankAccount duplicate =
            new BankAccount("Liam", 760);

        bool added = accounts.Add(duplicate);

        Console.WriteLine($"Duplicate added: {added}");

        DisplayAccounts(accounts);

        double[] balances = new double[accounts.Count];

        int index = 0;

        // Take each balance from the SortedSet
        // and put it into the double array
        foreach (BankAccount account in accounts)
        {
            balances[index] = (double)account.Balance;
            index++;
        }

        // Create the ScottPlot graph
        ScottPlot.Plot myPlot = new();

        // Add balances as bars
        myPlot.Add.Bars(balances);

        // Add axis labels
        myPlot.YLabel("Account Balance");
        myPlot.XLabel("Ranking");

        // Change label font sizes
        myPlot.Axes.Left.Label.FontSize = 20;
        myPlot.Axes.Bottom.Label.FontSize = 20;

        // Set margins
        myPlot.Axes.Margins(bottom: 0, top: .2);

        // Save graph as 800 x 600 PNG
        myPlot.SavePng("Topic7A-Task3.png", 800, 600);

        Console.WriteLine("\nGraph saved as Topic7A-Task3.png");
    }

    static void DisplayAccounts(SortedSet<BankAccount> accounts)
    {
        foreach (BankAccount account in accounts)
        {
            Console.WriteLine(account);
        }
    }
}
