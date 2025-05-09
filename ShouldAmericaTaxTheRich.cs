public class ShouldAmericaTaxTheRich
{
    /*
    The problem with even a “TINY” tax increase for the RICH, 
    which I and all others would graciously accept in order to 
    help the lower and middle income workers, is that the Radical 
    Left Democrat Lunatics would go around screaming,“Read my lips,” 
    the fabled Quote by George Bush the Elder that is said to have 
    cost him the Election. NO, Ross Perot cost him the Election! In 
    any event, Republicans should probably not do it, but I’m OK if 
    they do!!!
    */

    public void GeorgeTheElderScenario(bool raiseTaxesOnTheRich, bool rossPerotIsRunningForPresident)
    {
        string screamsOfRadicalLeftDemocratLunatics = string.Empty;

        // The problem with even a “TINY” tax increase for the RICH is that the Radical Left Democrat Lunatics would go around screaming,“Read my lips”
        if (raiseTaxesOnTheRich)
        {
            screamsOfRadicalLeftDemocratLunatics = "Read my lips";
        }

        if (WillRadicalLeftDemocratsCostRepublicansElections(screamsOfRadicalLeftDemocratLunatics, rossPerotIsRunningForPresident))
        {
            Console.WriteLine("This scenario is bad for Republican voters and all Americans.");
        }
        else
        {
            Console.WriteLine("This scenario is **NOT** bad for Republican voters or other Americans.");
        }
    }

    public bool WillRadicalLeftDemocratsCostRepublicansElections(string screamsOfRadicalLeftDemocratLunatics, bool rossPerotIsRunningForPresident)
    {
        // NO, Ross Perot cost him the Election!
        if (screamsOfRadicalLeftDemocratLunatics == "Read my lips" && rossPerotIsRunningForPresident)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
