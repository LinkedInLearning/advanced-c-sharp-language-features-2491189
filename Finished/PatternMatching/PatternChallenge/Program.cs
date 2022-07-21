// Example file for LinkedIn Learning Course "Advanced C#: Language Features by Joe Marini"
// C# Pattern Matching programming challenge

// The rules:
// A Stock trade of 0 shares should be caught and flagged as invalid
// A Stock trade that is less than $5,000 is a 0.1% commission
// A Stock trade that is more or equal to $5,000 is a 0.05% commission
// Any stock trade of 1,000 shares or more is a flat fee of $10
// Any Stock trade of 1,000 shares or more with a value of $10,000 or more is a flat fee of $5
// A Bond trade of 5 years duration is $20, or $15 if the total trade value is $10,000 or more
// Any bond trade of 10 years duration is $12
// A Bond trade of 20 years duration is $10, or $5 if the total value is $5,000 or more
// A Bond trade of any other duration should be caught and flagged as invalid

// Test code to test the trade commission calculation algorithm:
SecuritiesTrade[] tradeList = new SecuritiesTrade[] {
    new StockTrade(){Symbol="ABCD", Quantity=1200, Price=27.81m},
    new StockTrade(){Symbol="WXYZ", Quantity=1000, Price=7.92m},
    new StockTrade(){Symbol="ABCD", Quantity=200, Price=27.81m},
    new StockTrade(){Symbol="WXYZ", Quantity=400, Price=7.92m},
    new StockTrade(){Symbol="WXYZ", Quantity=0, Price=9.55m},
    new BondTrade(){Name="Abcd 5yr", Duration=5, Price=100.0m, Quantity=10},
    new BondTrade(){Name="Qwert 10yr", Duration=10, Price=100.0m, Quantity=10},
    new BondTrade(){Name="Abcd 20yr", Duration=20, Price=100.0m, Quantity=100},
    new BondTrade(){Name="Qwert 20yr", Duration=20, Price=50.0m, Quantity=10},
    new BondTrade(){Name="Qwert 50yr", Duration=50, Price=50.0m, Quantity=10},
};

foreach (var tradeItem in tradeList)
{
    try {
        CommisionCalculator.PrintTradeCommission(tradeItem);
    }
    catch (ArgumentException e) {
        Console.WriteLine($"{e.Message}");
    }
}
