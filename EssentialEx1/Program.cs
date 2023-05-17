//Завдання 1

//Використовуючи приклад виконаного домашнього завдання 3 з 14 уроку, реалізуйте можливість підключення
//    вашого простору імен та роботи з MyDictionary аналогічно екземпляру класу Dictionary.
using EssentialEx3;
namespace Essential18
{
    internal class Program
    {
        static void Main(string[] args)
        {
#warning Ексорт неймспейсу з іншого проекту 
            EssentialEx3.Dictionary<string,int> car = new EssentialEx3.Dictionary<string, int>();
            car.Add("Volkswagen Passat", 10000);
            car.Add("Audi RS6", 20000);

            Console.WriteLine($"Search by index: {car["Volkswagen Passat"]}");

            foreach(var item in car.Values)
            {
                Console.WriteLine($"Values by foreach:{item}");
            }

            foreach(var item in car.Key)
            {
                Console.WriteLine($"Key by foreach:{item}");
            }
        }
    }
}