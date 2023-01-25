using System;

namespace applicationtest
{
    //class Human
    //{
    //    public string Name;
    //    public string Surname;
    //    public int Age;

    //    public string GetFullname()
    //    {
    //        string info = $"FullName:{Name} {Surname} ";
    //        return info ;
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            //Human h1 = new Human();

            //h1.Name = "Vugar";
            //h1.Surname = "Ismayilov";
            //h1.Age = 21;
            //Console.WriteLine(h1.GetFullname());


            //Student telebe = new Student()
            //{
            //    FullName = "Vugar Ismayilov",
            //    GroupNo = "P231",
            //    Point = 64

            //};
            //Console.WriteLine(telebe.IsGraduated());

            //Product p1 = new Product("bmw", 20.999)
            //{

            //    DiscountPercent = 20
            //};

            //Console.WriteLine(p1.Name + "-" + p1.Price);


            //Notebook laptop = new Notebook();
            
            Notebook[] laptop = new Notebook[3];

            for (int i = 0; i < laptop.Length; i++)
            {
                Console.WriteLine("Mehsul adi:");
                string Brand = Console.ReadLine();
                
                Console.WriteLine("Mehsulun Modeli:");
                string Model = Console.ReadLine();

                double price;
                do
                {
                    Console.WriteLine("Qiymeti:");
                    string pricestr = Console.ReadLine();
                    price = Convert.ToDouble(pricestr);


                } while (price <= 0);

                Notebook notbook = new Notebook(Brand, Model, price);
                laptop[i] = notbook;
            }
           
            double sum = 0;
            for (int i = 0; i < laptop.Length; i++)
            {
                sum += laptop[i].Price; 
                
            }
            double avarage = sum / laptop.Length;

            Console.WriteLine(avarage);







        }
         
    }
}
