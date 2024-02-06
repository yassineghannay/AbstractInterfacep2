using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfacepart2
{
    internal class Program
    {

        string Name;
        string Colour;

        double Height;
        int Age;
        static void Main(string[] args)
        {


            Dog dog = new Dog();
            Cat cat = new Cat();


            Console.WriteLine("enter dog name ");
            dog.Name = Console.ReadLine();

            Console.WriteLine("height for the dog");
            dog.Height = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("enter  dog  height");
            dog.Colour =  Console.ReadLine();

            Console.WriteLine("Enter dog age");
            dog.Age = Convert.ToInt32(Console.ReadLine());

            dog.Eat();
            Console.Write($"the dog name is {dog.Name} , his height is {dog.Height} his colour is {dog.Colour} and his age is {dog.Age} also, "); dog.Eat();


            Console.WriteLine("enter cat name ");
            cat.Name = Console.ReadLine();

            Console.WriteLine("height for the cat");
            cat.Height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter  cat  height");
            cat.Colour = Console.ReadLine();

            Console.WriteLine("Enter cat age");
            cat.Age = Convert.ToInt32(Console.ReadLine());

            cat.Eat();
            Console.Write($"the dog name is {dog.Name} , his height is {dog.Height} his colour is {dog.Colour} and his age is {dog.Age} also, "); dog.Eat();







            Console.ReadKey();

        }
    }
}
