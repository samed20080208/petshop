using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop.Models
{
    class PetShop
    {
        public Animal[] Cats { get; set; }
        public Animal[] Dogs { get; set; }
        public Animal[] Birds { get; set; }
        public Animal[] Fishes { get; set; }

        public PetShop()
        {
            Cats = new Animal[0];
            Dogs = new Animal[0];
            Birds = new Animal[0];
            Fishes = new Animal[0];
        }

        public void RemoveByNickName(string nickname)
        {
            Cats = RemoveAnimalByNickname(Cats, nickname);
            Dogs = RemoveAnimalByNickname(Dogs, nickname);
            Birds = RemoveAnimalByNickname(Birds, nickname);
            Fishes = RemoveAnimalByNickname(Fishes, nickname);
        }

        private Animal[] RemoveAnimalByNickname(Animal[] animals, string nickname)
        {
            int index = Array.FindIndex(animals, animal => animal.Nickname == nickname);
            if (index != -1)
            {
                Animal[] newArray = new Animal[animals.Length - 1];
                Array.Copy(animals, 0, newArray, 0, index);
                Array.Copy(animals, index + 1, newArray, index, animals.Length - index - 1);
                return newArray;
            }
            return animals;
        }

        public void DisplayTotalMealsAndPrice()
        {
            int totalMeals = Cats.Length + Dogs.Length + Birds.Length + Fishes.Length;
            double totalPrice = GetTotalPrice(Cats) + GetTotalPrice(Dogs) +
                                GetTotalPrice(Birds) + GetTotalPrice(Fishes);

            Console.WriteLine($"Total meals served: {totalMeals}");
            Console.WriteLine($"Total price of all animals: {totalPrice:C}");
        }

        private double GetTotalPrice(Animal[] animals)
        {
            double totalPrice = 0;
            foreach (var animal in animals)
            {
                totalPrice += animal.Price;
            }
            return totalPrice;
        }
    }
}
