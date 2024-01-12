namespace Harjoitus_6
{
    internal class Animal
    {
        public string species;
        public string size;
        public string danger;
        public string canSwim;

        public Animal(string species, string size, string danger, string canSwim)
        {
            this.species = species;
            this.size = size;
            this.danger = danger;
            this.canSwim = canSwim;
        }
        public virtual void PrintInformation()
        {
            Console.WriteLine("Species: " + species);
            Console.WriteLine("Size: " + size);
            Console.WriteLine("Danger: " + danger);
            Console.WriteLine("Can the animal Swim: " + canSwim);
        }
    }
}
