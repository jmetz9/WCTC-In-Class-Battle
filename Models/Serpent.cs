using System;

namespace Battle.Models
{
    public class Serpent : IMonster
    {
        public Serpent()
        {
            Name = "Snake";
        }
        
        public string Name { get; set; }
        public void Roar()
        {
            Console.WriteLine("Instead of hissing, " + Name + " roars");
            
        }

        public void Stomp()
        {
            throw new System.NotImplementedException();
        }
    }
}