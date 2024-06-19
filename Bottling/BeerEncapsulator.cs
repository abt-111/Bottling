namespace Bottling
{
    internal class BeerEncapsulator
    {
        private float _avalaibleBeerVolume;
        private uint _avalaibleBottles, _avalaibleCapsules;

        public float AvalaibleBeerVolume => _avalaibleBeerVolume;

        public uint AvalaibleBottles => _avalaibleBottles;

        public uint AvalaibleCapsules => _avalaibleCapsules;

        public BeerEncapsulator(float avalaibleBeerVolume, uint avalaibleBottles, uint avalaibleCapsules)
        {
            _avalaibleBeerVolume = avalaibleBeerVolume;
            _avalaibleBottles = avalaibleBottles;
            _avalaibleCapsules = avalaibleCapsules;

        }

        public void AddBeerVolume(float beerVolume)
        {
            _avalaibleBeerVolume += beerVolume;
        }

        public void AddBottles(uint bottles)
        {
            _avalaibleBottles += bottles;
        }

        public void AddCapsules(uint capsules)
        {
            _avalaibleCapsules += capsules;
        }

        public uint ProduceEncapsulatedBeerBottles(uint beersToProduce)
        {
            uint beerMade = 0;

            for(int i = 0; i < beersToProduce; i++)
            {
                // Une bière peut être brassée s’il y a au moins une bouteille, …
                if (_avalaibleBottles > 0)
                {
                    //… 33 centilitres de bière et…
                    if (_avalaibleBeerVolume >= 0.33f)
                    {
                        // …une capsule
                        if (_avalaibleCapsules > 0)
                        {
                            _avalaibleBottles--;
                            _avalaibleBeerVolume -= 0.33f;
                            _avalaibleCapsules--;
                            beerMade++;
                            Console.WriteLine($"Beer n°{i + 1} made! - Beer volume level : {_avalaibleBeerVolume}");
                        }
                        else
                        {
                            Console.WriteLine($"You must add {beersToProduce - i} capsules to continue");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"You must add {(beersToProduce - i) * 0.33f}L of beer to continue");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"You must add {beersToProduce - i} bottles to continue");
                    break;
                }
            }

            return beerMade;
        }
    }
}
