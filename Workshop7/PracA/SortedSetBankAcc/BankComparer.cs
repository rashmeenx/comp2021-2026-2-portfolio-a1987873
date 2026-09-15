using System.Collections.Generic;

public class BankComparer : IComparer<BankAccount>
{
    public int Compare(BankAccount? x, BankAccount? y)
    {
        if (x == null || y == null)
        {
            return 0;
        }

        int balanceComparison = x.Balance.CompareTo(y.Balance);

        if (balanceComparison != 0)
        {
            return balanceComparison;
        }

        return string.Compare(x.Owner, y.Owner);
    }
}