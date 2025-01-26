namespace homework_ackend;

class Prog

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
    public static int k = Convert.ToInt32(Console.ReadLine());
    static void Maun(){
        /* практика А */
        Console.WriteLine($"Строчное значение:{name}.Число плавающей точкой:{bob}.Булевое значение:{fuf}.Целые числа:{gug}.Символ:{j}.");
        /* практика B*/
        Console.WriteLine(a+b);
        Console.WriteLine(a-b);
        Console.WriteLine(a*b);
        Console.WriteLine(a/b);
        /* практика С*/
        Console.WriteLine(k*5);
    }
    
}
