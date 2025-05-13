class Program
{
    static void Main(string[] args)
    {
        ShouldAmericaTaxTheRich shouldAmericaTaxTheRich = new ShouldAmericaTaxTheRich();
        bool raiseTaxes = true;
        Console.WriteLine("Was this outcome bad for everyone? " + shouldAmericaTaxTheRich.OutcomeOfTaxingTheRichIsBadForEveryone(raiseTaxes));
    }
}