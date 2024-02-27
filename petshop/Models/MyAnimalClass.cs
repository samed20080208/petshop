using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop.Models
{
    class Animal
    {
        public string Nickname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Energy { get; set; }
        public double Price { get; set; }

        public Animal(string nickname, int age, string gender, int energy, double price)
        {
            Nickname = nickname;
            Age = age;
            Gender = gender;
            Energy = energy;
            Price = price;
        }

        public void Eat()
        {
            Console.WriteLine($"{Nickname} is eating.");
            Energy += 10;
        }

        public void Sleep()
        {
            Console.WriteLine($"{Nickname} is sleeping.");
            Energy += 20;
        }

        public void Play()
        {
            if (Energy > 0)
            {
                Console.WriteLine($"{Nickname} is playing.");
                Energy -= 15;
            }
            else
            {
                Console.WriteLine($"{Nickname} doesn't have enough energy to play.");
            }
        }
    }
}
