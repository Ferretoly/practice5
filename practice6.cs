
namespace homeworkbackend;

class Program

{
  
   static void Main(){
    /* практика 1 */
    Console.Write("Назовите своё имя :");
    string n = Console.ReadLine(); 
    Console.WriteLine($"Привет {n}!");
    /* практика 2 */
    Console.Write("Введите свой год рождения :");
    int year = Convert.ToInt32(Console.ReadLine());
    if (year>2025){Console.WriteLine("Машину времени изобрёл?");}
    else{Console.WriteLine($"Ваш возраст : {2025-year}");}
    /* практика 4 */
    Console.Write("Введите 1-ое число :");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите 2-ое число :");
    double z = Convert.ToDouble(Console.ReadLine());
    if (x > z)
        {
            Console.WriteLine(x);
            Console.WriteLine(z);
        }
    else if (x == z){Console.WriteLine("Числа равны");}
    else
        {
            Console.WriteLine(z);
            Console.WriteLine(x);
        }
    /* практика 5 */
    Console.Write("Введите число :");
    int number = Convert.ToInt32(Console.ReadLine());
        
    int i = 10;

    if (number>1000){Console.WriteLine("Диапазон от 100 до 999");}
    else if (number<100){Console.WriteLine("Диапазон от 100 до 999");}
    else{
        int hundred = number / 100;
        int ten = number / 10;
        int tens = ten %10;
        int units = number % 10;
        Console.Write($"Сотни {hundred} десятки {tens} единицы {units}");
    }
    


   }

    
}