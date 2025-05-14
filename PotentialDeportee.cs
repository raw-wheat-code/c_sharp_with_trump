
public class PotentialDeportee
{
    public string? criminalType { get; set; }
    public string? alias { get; set; }
    public Citizenship citizenship { get; set; }
    public string? crimeCategory { get; set; }
    public int? criminalityIndex { get; set; }

    public PotentialDeportee(string alias)
    {
        this.alias = alias;
        citizenship = DeportationDictionaries.citizenshipIndex[alias];
    }
}