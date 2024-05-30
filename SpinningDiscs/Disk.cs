namespace SpinningDiscs
{
    public abstract class Disc : IDisc
    {
        public string Name { get; set; }
        public double Capacity { get; set; } // in MB
        public string Content { get; set; }

        public Disc(string name, double capacity, string content)
        {
            Name = name;
            Capacity = capacity;
            Content = content;
        }

        public virtual void SpinDisc()
        {
            Console.WriteLine($"{Name} is spinning.");
        }

        public virtual void StopDisc()
        {
            Console.WriteLine($"{Name} has stopped spinning.");
        }

        public virtual void Play()
        {
            Console.WriteLine($"Playing {Name}.");
        }

        public virtual void Pause()
        {
            Console.WriteLine($"Pausing {Name}.");
        }
    }
}
