using Bottling;

internal class Program
{
    private static void Main(string[] args)
    {
        int beerMade;

        BeerEncapsulator theBeerMustBeMade = new BeerEncapsulator(8.0f, 100, 100);

        beerMade = theBeerMustBeMade.ProduceEncapsulatedBeerBottles(100);

        Console.WriteLine($"You made {beerMade} beers");

        theBeerMustBeMade.AddBeer(24.75f);

        beerMade = theBeerMustBeMade.ProduceEncapsulatedBeerBottles(100 - beerMade);

        Console.WriteLine($"You made {beerMade} beers");
    }
}