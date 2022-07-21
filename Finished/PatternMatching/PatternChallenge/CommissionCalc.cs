// Example file for LinkedIn Learning Course "Advanced C#: Language Features by Joe Marini"
// C# Pattern Matching programming challenge

// Code to calculate the trade commission
public class CommisionCalculator
{
    public static decimal CalculateTradeCommission(SecuritiesTrade trade) => trade switch
    {
        StockTrade { Quantity: var q } when q == 0 => throw new ArgumentException("Invalid trade, can't be 0 shares"),
        StockTrade { Quantity: var q, Price: var p } when q >= 1000 && (q * p) >= 10000.0m => 5.0m,
        StockTrade { Quantity: var q } when q >= 1000 => 10.0m,
        StockTrade { Quantity: var q, Price: var p } when (q * p) >= 5000.0m => (q * p) * 0.005m,
        StockTrade { Quantity: var q, Price: var p } => (q * p) * 0.01m,
        BondTrade { Quantity: var q, Price: var p, Duration: var d} when d == 5 && (q * p) >= 10000.0m => 15.0m,
        BondTrade { Quantity: var q, Price: var p, Duration: var d} when d == 5 => 20.0m,
        BondTrade { Quantity: var q, Price: var p, Duration: var d} when d == 10 => 12.0m,
        BondTrade { Quantity: var q, Price: var p, Duration: var d} when d == 20 && (q * p) >= 5000.0m => 5.0m,
        BondTrade { Quantity: var q, Price: var p, Duration: var d} when d == 20 => 10.0m,
        _ => throw new ArgumentException("Unknown trade type!")
    };

    public static void PrintTradeCommission(SecuritiesTrade trade)
    {
        decimal commission = 0.0m;

        commission = CalculateTradeCommission(trade);

        if (trade is StockTrade st)
        {
            Console.WriteLine($"Stock trade of {st.Quantity} of {st.Symbol} is {commission:C}");
        }
        else if (trade is BondTrade bt)
        {
            Console.WriteLine($"Bond trade of {bt.Quantity} of {bt.Name} is {commission:C}");
        }
    }
}
