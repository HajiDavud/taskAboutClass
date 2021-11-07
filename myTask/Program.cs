using System;

namespace myTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk[] array = new Milk[0];
            string answer = "yes";

            while(answer == "yes")
            {
                int price, count, volume, fatRate;
                string name;
                Array.Resize<Milk>(ref array, array.Length + 1);
                Console.WriteLine("Count--> ");
                count = int.Parse(Console.ReadLine());
                Console.WriteLine("Price--> ");
                price = int.Parse(Console.ReadLine());
                Console.WriteLine("Volume--> ");
                volume = int.Parse(Console.ReadLine());
                Console.WriteLine("Fatrate--> ");
                fatRate = int.Parse(Console.ReadLine());
                Console.WriteLine("Product Name--> ");
                name = Console.ReadLine();
                array[array.Length - 1] = new Milk(name, price, count, volume, fatRate);
                Console.WriteLine("Do you want to continue?: (yes/no)");
                answer = Console.ReadLine();

            }

            foreach (var obj in array)
            {
                Console.WriteLine("Product Name: " + obj.name);
                Console.WriteLine("Price : " + obj.price);
                Console.WriteLine("FatRate: " + obj.fatRate);
            }



            Console.WriteLine("======================\nSTUDENT TASK");
            Student davud = new Student();
            Student sadiq = new Student();
            Student murad = new Student();

            Student.ShowInstanceCount();

            Console.WriteLine("======================\nKok alti 3 cu dereceden Taski");

            Console.WriteLine("Reqemi Daxil Edin");
            int reqem = int.Parse(Console.ReadLine());

            int i = 1;
            while (i< reqem)
            {
                if (i * i * i == reqem)
                {
                    Console.WriteLine("Edediniz: "+i);
                    break;
                }
                else
                {
                    if (i * i * i > reqem)
                    {
                        Console.WriteLine("Bele bir eded tapilmadi");
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
            }


        }
    }
    class Product
    {
        public string name;
        public int price;
        public int count;
        public int TotalIncome = 0;


        public Product(string name, int price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;

        }

        public void Sell()
        {
            if (0 >= count)
            {
                Console.WriteLine("Bu Qeder Mehsul Yoxumuzdur ");

            }
            else
            {
                TotalIncome += price;

            }
        }


    }

    class Milk : Product
    {
        int valume;
        public int fatRate;

        public Milk(string name, int price, int count, int valume, int fatRate) : base(name, price, count)
        {
            this.valume = valume;
            this.fatRate = fatRate;
        }


    }


    class Student
    {
        static int instanceCount = 0;
        public Student()
        {
            instanceCount += 1;
        }

        public static void ShowInstanceCount()
        {
            Console.WriteLine("Instances : "+instanceCount);
        }


    }
}
