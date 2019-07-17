using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var RedAnts = new Ants("Red Ants", 2500, 5);
            var Betty = new BettaFish("Betty", 10);
            var Coop = new CopperHead("Cooper");
            var Jim = new Earthworm("Jim", 5);
            var Fin = new Finch("Fin", 2);
            var Kia = new Gerbil("Kia");
            var Mickey = new Mouse("Mickey");
            var Tweety = new Parakeet("Tweety", 1);
            var Tim = new TimberRattleSnake("Tim");
            var Terp = new Terrapin("Terp", 10);

            var diggingAnimals = new Diggers();

            diggingAnimals.diggers.Add(RedAnts);
            diggingAnimals.diggers.Add(Jim);

            var flyingAnimals = new Flyers();

            flyingAnimals.flyers.Add(Fin);
            flyingAnimals.flyers.Add(Tweety);

            var swimmingAnimals = new Swimmers();

            swimmingAnimals.swimmers.Add(Betty);
            swimmingAnimals.swimmers.Add(Terp);

            var walkingAnimals = new Walkers();

            walkingAnimals.walkers.Add(RedAnts);
            walkingAnimals.walkers.Add(Coop);
            walkingAnimals.walkers.Add(Kia);
            walkingAnimals.walkers.Add(Fin);
            walkingAnimals.walkers.Add(Mickey);
            walkingAnimals.walkers.Add(Tim);
            walkingAnimals.walkers.Add(Terp);
            walkingAnimals.walkers.Add(Tweety);

        }
    }
}
