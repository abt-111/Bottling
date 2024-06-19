using Bottling;

internal class Program
{
    private static void Main(string[] args)
    {
        bool isFinished = false;
        int bottles, capsules;
        float beerVolume;

        while (!isFinished)
        {
            // L'utilisateur doit saisir combien de litres de bière, …
            beerVolume = ValidUserInputFloat("Entres une quantité de bière : ");
            // … de bouteilles vides et…
            bottles = ValidUserInputInteger("Entres une quantité de bouteille : ");
            // … de capsules sont disponibles
            capsules = ValidUserInputInteger("Entres une quantité de bière : ");

            isFinished = true;
        }

        /*int beerMade;

        BeerEncapsulator theBeerMustBeMade = new BeerEncapsulator(8.0f, 100, 100);

        beerMade = theBeerMustBeMade.ProduceEncapsulatedBeerBottles(100);

        Console.WriteLine($"You made {beerMade} beers");

        theBeerMustBeMade.AddBeer(24.75f);

        beerMade = theBeerMustBeMade.ProduceEncapsulatedBeerBottles(100 - beerMade);

        Console.WriteLine($"You made {beerMade} beers");*/
    }

    public static int ValidUserInputInteger(string messageForUser)
    {
        bool isValid = false;
        int validInteger = 0;
        string userInput;

        while (!isValid)
        {
            Console.Write(messageForUser);
            userInput = Console.ReadLine();

            isValid = int.TryParse(userInput, out validInteger);

            if (!isValid)
            {
                Console.WriteLine($"Tu dois entrer un entier compris entre {Int32.MinValue} et {Int32.MaxValue} \n");
            }
        }

        return validInteger;
    }

    public static float ValidUserInputFloat(string messageForUser)
    {
        bool isValid = false;
        float validFloat = 0.0f;
        string userInput;

        while (!isValid)
        {
            Console.Write(messageForUser);
            userInput = Console.ReadLine();

            isValid = float.TryParse(userInput, out validFloat);

            if (!isValid)
            {
                Console.WriteLine($"Tu dois entrer un nombre réel compris entre {Single.MinValue} et {Single.MaxValue} \n");
            }
        }

        return validFloat;
    }
}