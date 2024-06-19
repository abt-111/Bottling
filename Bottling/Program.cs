namespace Bottling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Le nombre de capsules et de bouteilles ne peut pas être négatif
            uint quantityOfBeersToProduce;
            BeerEncapsulator beerEncapsulator = new BeerEncapsulator(0.0f, 0, 0);

            // Initialisation
            AddComponents(beerEncapsulator);

            quantityOfBeersToProduce = InputValidator.ValidUserInputUnsignedInteger("Entres une quantité de bouteilles bières à produire : ");

            while (quantityOfBeersToProduce > 0)
            {
                // Ajouter des composants
                quantityOfBeersToProduce -= beerEncapsulator.ProduceEncapsulatedBeerBottles(quantityOfBeersToProduce);
                // Ajouter des composants
                if (quantityOfBeersToProduce > 0) AddComponents(beerEncapsulator);
            }

            Console.WriteLine("La production s'est terminé avec succès\n");
        }

        public static void AddComponents(BeerEncapsulator beerEncapsulator)
        {
            uint bottles, capsules;
            float beerVolume;

            Console.WriteLine("Ajout de composants\n");
            // L'utilisateur doit saisir combien de litres de bière, …
            beerVolume = InputValidator.ValidUserInputFloat("Entres une quantité de bière : ");
            // … de bouteilles vides et…
            bottles = InputValidator.ValidUserInputUnsignedInteger("Entres une quantité de bouteille : ");
            // … de capsules sont disponibles
            capsules = InputValidator.ValidUserInputUnsignedInteger("Entres une quantité de bière : ");

            beerEncapsulator.AddBeerVolume(beerVolume);
            beerEncapsulator.AddBottles(bottles);
            beerEncapsulator.AddCapsules(capsules);
        }
    }
}