using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership
{
    public class carsDetails
    {
        public void Lamborghini()
        {
            int price = 608358;
            string colors = "Black Blue Yellow";
            int speed = 400;

            Console.WriteLine("Lamborghini Revuelto");
            Console.WriteLine("Price : "+price+"$");
            Console.WriteLine("Colors : "+colors);
            Console.WriteLine("speed : "+speed+"KMH");
        }

        public void Bugatti()
        {
            int price = 3000000;
            string colors = "Black Red";
            int speed = 450;

            Console.WriteLine("Bugatti Veyron");
            Console.WriteLine("Price : " + price + "$");
            Console.WriteLine("Colors : " + colors);
            Console.WriteLine("speed : " + speed + "KMH");
        }

        public void FordMustang()
        {
            int price = 32510;
            string colors = "Yellow Red";
            int speed = 350;

            Console.WriteLine("Mustang GT");
            Console.WriteLine("Price : " + price + "$");
            Console.WriteLine("Colors : " + colors);
            Console.WriteLine("speed : " + speed + "KMH");
        }

        public void RolceRoyce()
        {
            int price = 475000;
            string colors = "All Colors Available";
            int speed = 250;

            Console.WriteLine("RR Phantom");
            Console.WriteLine("Price : " + price + "$");
            Console.WriteLine("Colors : " + colors);
            Console.WriteLine("speed : " + speed + "KMH");
        }

        public void Ferrari()
        {
            int price = 398350;
            string colors = "All Colors Available";
            int speed = 390;

            Console.WriteLine("Ferrari Purosangue");
            Console.WriteLine("Price : " + price + "$");
            Console.WriteLine("Colors : " + colors);
            Console.WriteLine("speed : " + speed + "KMH");
        }
    }
    internal class Program:carsDetails
    {
        static void Main(string[] args)
        {
            string[] cars = new string[5] { "lamborghini", "bugatti", "ford ustang", "rolceroyce", "ferrari" };

            Console.WriteLine("welcome to car dealership program ! \ncheck latest car models\n1." + cars[0] +"\n2."+ cars[1]+"\n3."+ cars[2] +"\n4."+ cars[3] +"\n5."+ cars[4]);
            Console.Write("enter name to check : ");
            string carName = Console.ReadLine();

            Boolean flag = false;
            int index;

            carsDetails Details = new carsDetails();

            for (int i = 0; i < cars.Length; i++)
            {
                if(carName == cars[i])
                {
                    flag = true;
                    break;
                }
            }
            if(flag && carName == cars[0])
            {
                Details.Lamborghini();
            }
            else if(flag && carName == cars[1])
            {
                Details.Bugatti();
            }
            else if (flag && carName == cars[2])
            {
                Details.FordMustang();
            }
            else if (flag && carName == cars[3])
            {
                Details.RolceRoyce();
            }
            else if (flag && carName == cars[4])
            {
                Details.Ferrari();
            }
            Console.ReadLine();

        }
    }
}
