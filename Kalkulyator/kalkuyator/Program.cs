using System.Runtime.CompilerServices;
Console.Write("Kalkuyator proqramina xos gelmisiniz! Baslamaq ucun y yaz! ");
string y = Console.ReadLine();

if (y != "y")
{
    return;
}

Console.Write("birinci reqemi girin: ");
int ilk = Convert.ToInt32(Console.ReadLine());

Console.Write("ikinci reqemi girin: ");
int iki = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hansi emeliyyati etmek isteyirsiniz?");
Console.WriteLine("1-Toplama\n2-Çıxma\n3-Qalıqlı bölme\n4-Qalıqsız bölme\n5-Qalan qalıq\n6-Faiz hesabı\n7-Modullu cixma");
string secme = Console.ReadLine();

switch (secme)
{
    case "1":
        Console.WriteLine("Netice: " + Topla(ilk, iki));
        break;
    case "2":
        Console.WriteLine("Netice: " + Cix(ilk, iki));
        break;
    case "3":
        Console.WriteLine("Netice: " + Qaliqlibol(ilk, iki));
        break;
    case "4":
        Console.WriteLine("Netice: " + QaliqsizBol(ilk, iki));
        break;
    case "5":
        Console.WriteLine("Netice: " + Qalanqaliq(ilk, iki));
        break;
    case "6":
        Console.WriteLine("Netice: " + Faiz(ilk, iki));
        break;  
    case "7":
        Console.WriteLine("Netice: " + ModCix(ilk, iki));
        break;
}

static int Topla(int a, int b)
{
    return a + b;
}
static int Cix(int a, int b)
{
    return a - b;
}
static int ModCix(int a, int b)
{
    return Math.Abs(a - b);
}
static int QaliqsizBol(int a, int b)
{
    return a / b;
}
static double Qaliqlibol(int a, int b)
{
    return (double)a / b;
}
static double Qalanqaliq(int a, int b)
{
    return (double)a % b;
}
static int Faiz(int a,int b)
{
    return a * b / 100;   
}










