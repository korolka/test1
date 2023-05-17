//Завдання 2

//Створіть клас із методом позначеним модифікатором доступу public. 
//    Доведіть, що до цього методу можна звернутися не тільки з поточного складання, але і з похідного класу зовнішнього складання.
using EssentialEx2;
using EssentialEx2New;

namespace EssentialEx2
{
    internal class Program//:Class2
    {
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            class2.Method2();
        }
    }
    public class Class1
    {
        public int Id { get; set; }

        public Class1()
        {

        }
        public Class1(int id)
        {
            Id = id;
        }

        public void Method()
        {
            Console.WriteLine($"Method in class1 id: {Id}");
        }
    }
}

namespace EssentialEx2New
{
    class Class2: Class1
    {
        public void Method2()
        {
            Class1 class1= new Class1(1234);
            class1.Method();
        }
    }
}