// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini

// StockRecord is a sample class that returns information about
// a week's worth of stock information - closing prices, etc.
public class StockRecord {
    public string Symbol {
        get => "ABCD";
    }

    private decimal[] prices = new decimal[] {
        105.1m, 103.12m, 106.93m, 104.5m, 103.7m
    };

    // Define some public properties
    public decimal Average {
        get => prices.Sum() / prices.Length;
    }
    public decimal High {
        get => prices.Max();
    }
    public decimal Low {
        get => prices.Min();
    }

    // TODO: implement Length property 
    public int Length => prices.Length;

    // TODO: implement this[] to enable indexing
    public decimal this[int index] {
        get => prices[index];
    }
    // TODO: You can overload the indexer to provide another way to access
    public decimal this [string day] {
        get {
            if (day == "mon") {
                return prices[0];
            }
            if (day == "tue") {
                return prices[1];
            }
            if (day == "wed") {
                return prices[2];
            }
            if (day == "thu") {
                return prices[3];
            }
            if (day == "fri") {
                return prices[4];
            }
            throw new IndexOutOfRangeException($"'{day}' is not a valid index to StockRecord");
        }
    }
}
