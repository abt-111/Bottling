namespace Bottling
{
    internal class BeerEncapsulator
    {
        private float _avalaibleBeerVolume;
        private int _avalaibleBottles;
        private int _avalaibleCapsules;

        public float AvalaibleBeerVolume => _avalaibleBeerVolume;

        public int AvalaibleBottles => _avalaibleBottles;

        public int AvalaibleCapsules
        {
            get => _avalaibleCapsules;
            set => _avalaibleCapsules = value;
        }

        public BeerEncapsulator(float avalaibleBeerVolume, int avalaibleBottles, int avalaibleCapsules)
        {
            _avalaibleBeerVolume = avalaibleBeerVolume;
            _avalaibleBottles = avalaibleBottles;
            _avalaibleCapsules = avalaibleCapsules;

        }

        public void AddBeer(float beer)
        {
            _avalaibleBeerVolume += beer;
        }

        public int ProduceEncapsulatedBeerBottles(int bottlesQuantity)
        {
            int beerMade = 0;

            for(int i = 0; i < bottlesQuantity; i++)
            {
                if(_avalaibleBottles > 0)
                {
                    if (_avalaibleBeerVolume >= 0.33f)
                    {
                        if(_avalaibleCapsules > 0)
                        {
                            _avalaibleBottles--;
                            _avalaibleBeerVolume -= 0.33f;
                            _avalaibleCapsules--;
                            beerMade++;
                            Console.WriteLine($"Beer n°{i + 1} made! - Beer volume level : {_avalaibleBeerVolume}");
                        }
                        else
                        {
                            Console.WriteLine($"You must add {bottlesQuantity - i} capsules to continue");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"You must add {(bottlesQuantity - i) * 0.33f}L of beer to continue");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"You must add {bottlesQuantity - i} bottles to continue");
                    break;
                }
            }

            return beerMade;
        }
    }
}
