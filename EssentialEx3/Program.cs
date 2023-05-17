//Завдання 3

//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//    Створіть колекцію MyDictionary. Реалізуйте у найпростішому наближенні можливість
//    використання її екземпляра аналогічно екземпляру класу Dictionary. 
//    Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання елемента,
//    індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання 
//    для отримання загальної кількості елементів. Реалізуйте можливість перебору елементів колекції у циклі наперед.


namespace EssentialEx3
{
     class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> directory = new Dictionary<int, string>();
            directory.Add(1111, "Message 1");
            directory.Add(21432, "Message 2");
            directory.Add(224, "Message 3");
            directory[1111] = "New Message 1";
            directory[1413] = "afa";// Check. Is exist key?
            foreach(string item in directory.Values)
                Console.WriteLine(item);
            
            foreach(int item in directory.Key)
                Console.WriteLine(item);
        }
    }
}