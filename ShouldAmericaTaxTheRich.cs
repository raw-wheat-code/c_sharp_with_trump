public class ShouldAmericaTaxTheRich
{
    // The problem with even a “TINY” tax increase for the RICH...
    bool taxesIncreasedATinyBitForTheRich = false;

    // which I and all others would graciously accept in order to help the lower and middle income workers,
    bool TheRichGraciouslyAcceptATinyTaxIncrease = true;

    // is that the Radical Left Democrat Lunatics would go around screaming,“Read my lips,” 
    string screamsOfRadicalLeftDemocratLunatics = string.Empty;

    public string OutcomeOfTaxingTheRichIsBadForEveryone(bool raiseTaxes)
    {
        taxesIncreasedATinyBitForTheRich = raiseTaxes;
        screamsOfRadicalLeftDemocratLunatics = taxesIncreasedATinyBitForTheRich ? "Read my lips" : string.Empty;

        // the fabled Quote by George Bush the Elder that is said to have cost him the election.
        string RadicalLeftDemocratsWillCostRepublicansElections = ThisIsBadForRepublicans(screamsOfRadicalLeftDemocratLunatics);

        // In any event, Republicans should probably not do it,
        bool republicansShouldRaiseTaxes = raiseTaxes;

        // but I’m OK if they do!!!
        bool trumpIsOkWithIt = true;

        return TheRichGraciouslyAcceptATinyTaxIncrease && trumpIsOkWithIt && republicansShouldRaiseTaxes ? RadicalLeftDemocratsWillCostRepublicansElections : "No";

    }

    public string ThisIsBadForRepublicans(string screamsOfRadicalLeftDemocratLunatics)
    {
        // NO, Ross Perot cost him the Election!
        bool rossPerotIsRunningForPresident = false;

        if (screamsOfRadicalLeftDemocratLunatics == "Read my lips" && rossPerotIsRunningForPresident)
        {
            return "Yes";
        }
        else
        {
            return "No";
        }
    }
}
