public static class DeportationDictionaries
{
    public static Dictionary<string, string> aliases = new Dictionary<string, string>
        {
            { "MS-13", "Hispanic" }, { "Hispanic", "Hispanic" }, { "Hispanic-looking", "Hispanic" },
            { "Illegal Immigrant", "Hispanic" }, { "Asylum Seaker", "Hispanic" }, { "Green Card Holder", "Hispanic" },
            { "Refugee", "Hispanic" }, { "Non-White", "Non-white" }, { "African American", "Non-white" },
            { "Naturalized Citizen", "Non-white" }, { "Radical Leftist", "Democrat" }, { "Democrat", "Democrat" },
            { "3rd Party Voter", "Democrat" }, { "White", "American Citizen" }, { "American Citizen", "American Citizen" },
            { "Conservative Non-Maga", "White" }, { "MAGA Pleb", "Loyalist" }, { "MAGA Controlling Class Loyalist", "Loyalist" }
        };

    public static Dictionary<string, int> criminalityIndex = new Dictionary<string, int>
        {
            { "Murder", 10 }, { "Violent Crime", 9 }, { "Political Dissenter", 8 }, { "Non-Violent Crime", 7 }, { "Non-Offender", 1 }
        };

    public static Dictionary<string, Citizenship> citizenshipIndex = new Dictionary<string, Citizenship>()
        {
            { "Hispanic", new Citizenship { citizen = false, factor = 10 } },
            { "Non-white", new Citizenship { citizen = null, factor = 10 } },
            { "Democrat", new Citizenship { citizen = true, factor = 10 } },
            { "American Citizen", new Citizenship { citizen = true, factor = 2 } },
            { "White", new Citizenship { citizen = true, factor = 1 } },
            { "Loyalist", new Citizenship { citizen = null, factor = -100 } }
        };
}