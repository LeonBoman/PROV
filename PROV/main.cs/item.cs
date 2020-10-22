using System;

namespace code
{
    public class item
    {
        //Skapar alla book variabler
        Random generator = new Random();
        public int price;
        public string[] name = {"Illiad", "Odyssey", "De Re publica"};
        public int nameArrayNumber;
        public int rarity;
        public string[] rarityText = {"Common", "Uncommon", "Rare", "Epic", "Legendary"};
        public string[] category = {"Adventure", "War", "Society"};
        public int categoryArrayNumber;
        public int actualPrice;
        public bool[] cursed = {true, false};
        public int cursedArrayNumber;

        public item()
        {
            //han inte klart med allt här, men gjorde en massa randomizers
            nameArrayNumber = generator.Next(3);
            price = generator.Next(200);
            rarity = generator.Next(5);
            cursedArrayNumber = generator.Next(2);
            categoryArrayNumber = generator.Next(3);
            actualPrice = price * rarity;
            
        }
    }
}
