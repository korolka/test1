//Завдання 4

//Створіть власний простір імен MyNamespace з класом MyClass і підключіть його до іншої програми.
using System.Security.Cryptography;
using MyNamespace;

namespace EssentialEx4
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Method();
            Console.WriteLine("Something");
            
        }
    }
}

