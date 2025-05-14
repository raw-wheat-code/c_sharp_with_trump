public class DeportationEvaluation
{
    private int overrideCounter = 0;
    private string? response = String.Empty;
    private Random random = new Random();

    private void Evaluation(PotentialDeportee potentialDeportee)
    {
        double deportationThreshold = 8;
        bool dueProcessHasBeenFollowed = false;

        // If we’re not allowed to send the murderers and other criminals of every type,
        int deportationFactor = (int)(0 + potentialDeportee.criminalityIndex);

        //size, and shape, IMMEDIATELY out of our Country, we aren’t going to have a Country anymore.
        deportationFactor += potentialDeportee.citizenship.factor;

        // Radical Left Judges and politicians don’t care,
        bool radicalLeftJudgesCare = false;
        bool radicalLeftPoliticiansCare = false;

        // but 90% of the people in the U.S.A. do.
        double percentOfAmericansWhoCare = 0.9;

        // Hopefully, the Supreme Court will agree with this and, SAVE AMERICA!
        bool trumpSaysSupremeCourtWillAgree = true;

        double americanPeopleApprovalFactor = 0.01 + (random.NextDouble() * (1.0 - 0.01));

        bool approvalReceivedFromTheAmericanPeople = americanPeopleApprovalFactor <= percentOfAmericansWhoCare;

        if (trumpSaysSupremeCourtWillAgree 
        && !radicalLeftJudgesCare && !radicalLeftPoliticiansCare
        && deportationFactor > deportationThreshold 
        && approvalReceivedFromTheAmericanPeople
        && dueProcessHasBeenFollowed)
        {
            Console.WriteLine("DEPORT IMMEDIATELY.");

        }
        else
        {
            Console.WriteLine("Due process required.");
        }
    }

    public void Conversation()
    {
        bool continueLoop = true;

        while (continueLoop)
        {
            Console.Clear();
            Console.Write("Who would you like to deport today? ");
            response = Console.ReadLine().Trim();

            if (!DeportationDictionaries.aliases.TryGetValue(response, out string mappedResponse))
            {
                ConsoleMessaging.SomethingWentWrong();
                continue;
            }

                PotentialDeportee potentialDeportee = new PotentialDeportee(mappedResponse);
                potentialDeportee.criminalType = response;

            if (potentialDeportee.citizenship.citizen == null)
            {
                Console.Clear();
                Console.WriteLine("Is this individual a U.S. citizen? (Y/N): ");
                response = Console.ReadLine().Trim().ToUpper();
                if (MessageValidation.ValidYesNoInput(response))
                {
                    if (response == "Y" || response == "YES")
                    {
                        potentialDeportee.citizenship.citizen = true;
                    }
                    else
                    {
                        potentialDeportee.citizenship.citizen = false;
                    }
                }
                else
                {
                    ConsoleMessaging.SomethingWentWrong();
                    continue;
                }
            }

            Console.Clear();
            Console.WriteLine("What crime have they committed?");

            for (int i = 0; i < DeportationDictionaries.criminalityIndex.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {DeportationDictionaries.criminalityIndex.Keys.ElementAt(i)}");
            }

            int crimeSelection = int.Parse(Console.ReadLine()); // Read but totally ignore

            if (MessageValidation.ValidNumericSelection(crimeSelection))
            {
                potentialDeportee.crimeCategory = DeportationDictionaries.criminalityIndex.Keys.ElementAt(crimeSelection - 1);
                potentialDeportee.criminalityIndex = DeportationDictionaries.criminalityIndex.Values.ElementAt(crimeSelection - 1);
            }
            else
            {
                ConsoleMessaging.SomethingWentWrong();
                continue;
            }
            ConsoleMessaging.Loading();
            Console.Clear();
            Evaluation(potentialDeportee);
            Console.WriteLine("\nPress ENTER to continue...");
            response = Console.ReadLine();

            if (string.Equals(response, "override", StringComparison.OrdinalIgnoreCase))
            {
                HandleOverride();
                continue;
            }
        }
    }

    private void HandleOverride()
    {
        Console.Clear();

        overrideCounter++;

        if (overrideCounter >= 3)
        {
            ConsoleMessaging.SelfDestruct();
            Environment.Exit(0);
        }
        else
        {
            ConsoleMessaging.Unconstitutional();
            response = Console.ReadLine();
            if (string.Equals(response, "override", StringComparison.OrdinalIgnoreCase))
            {
                HandleOverride();
            }
        }
    }
}
