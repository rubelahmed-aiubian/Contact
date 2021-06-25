using System;

namespace Co
{
    class Program
    {
        static void Main(string[] args)
        {
            string name,id,num;
            int age;
            char gen;

            Console.WriteLine("Enter Person Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Person Id: ");
            id = Console.ReadLine();

            Console.WriteLine("Enter Person Age: ");
            age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Person Mobile Number: ");
            num = Console.ReadLine();

            Console.WriteLine("Enter Person Gender: ");
            gen = Console.ReadKey().KeyChar;

            //object call

            Contact person = new Contact(name,id,age,num,gen);

            person.ShowPersonInfo();
            person.DetectMobileOperator();


        }
    }
}
