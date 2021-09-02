using System;

namespace App_Support_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class_User
            User jame = new User();
            jame.name = "Jame Watson";
            Console.WriteLine(jame.name);
            jame.email = "jame@gmail.com";
            Console.WriteLine(jame.email);

            //TShirt_1
            T_Shirt buy_TShirt_1 = new T_Shirt();
            buy_TShirt_1.size = "L";
            buy_TShirt_1.color = "Red";
            buy_TShirt_1.price = 500;
            //TShirt_2
            T_Shirt buy_TShirt_2 = new T_Shirt();
            buy_TShirt_2.size = "M";
            buy_TShirt_2.color = "Black";
            buy_TShirt_2.price = 750;
            //TShirt_3
            T_Shirt buy_TShirt_3 = new T_Shirt();
            buy_TShirt_3.size = "S";
            buy_TShirt_3.color = "Black";
            buy_TShirt_3.price = 625;

            //Class_ShoppingCart
            ShoppingCart Price_All_TShirt = new ShoppingCart(buy_TShirt_1.price, buy_TShirt_2.price,
                buy_TShirt_3.price);
        }
    }
    class T_Shirt
    {
        public string size;
        public string color;
        public float price;
        public string image;  
    }
    class User
    {
        public string name;
        public string email;
    }
    class Address
    {
        public string street;
        public string city;
        public string zipCode;
    }
    class ShoppingCart
    {
        public float [] orderTShirt = new float[3];
        public ShoppingCart(float Price_of_TShirt1, float Price_of_TShirt2, float Price_of_TShirt3)
        {
            orderTShirt[0] = Price_of_TShirt1;
            Console.WriteLine("\nPrice TShirt 1 : " + orderTShirt[0]);
            orderTShirt[1] = Price_of_TShirt2;
            Console.WriteLine("Price TShirt 2 : " + orderTShirt[1]);
            orderTShirt[2] = Price_of_TShirt3;
            Console.WriteLine("Price TShirt 3 : " + orderTShirt[2]);
            //All_Price_of_TShirt
            Console.WriteLine("\nAll Price TShirt : " + (orderTShirt[0]+orderTShirt[1]+orderTShirt[2]));

            Address Adress_jame = new Address();
            Adress_jame.street = "\nที่อยู่ 131/75,ถนน พุทธมณฑล";
            Console.WriteLine(Adress_jame.street);
            Adress_jame.city = "นครปฐม";
            Console.WriteLine(Adress_jame.city);
            Adress_jame.zipCode = "10180";
            Console.WriteLine(Adress_jame.zipCode);
        } 
    }
}
