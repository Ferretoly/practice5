namespace homework_ackend;

class Program

{
    /* практика А */
    public static string name = "Chocolate";
    public static double bob = 5.5;
    public static bool fuf = true;
    public static int gug = 3;
    public static char j = 'c';
    /* практика B*/
    public static double a = Convert.ToDouble(Console.ReadLine());
    public static double b = Convert.ToDouble(Console.ReadLine());
    /* практика С*/
    public static int с = Convert.ToInt(Console.ReadLine());
    static void Maun(){
        /* практика А */
        Console.WriteLine($"Строчное значение:{name}.Число с плавающей точкой:{bob}.Булевое значение:{fuf}.Целые числа:{gug}.Символ:{j}.");
        /* практика B*/
        Console.WriteLine(a+b);
        Console.WriteLine(a-b);
        Console.WriteLine(a*b);
        Console.WriteLine(a/b);
        /* практика С*/
        Console.WriteLine(c*5);
    }
    
}
