// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.Write("Ayın numarasını girin (1-12): ");
int ay = Convert.ToInt32(Console.ReadLine());

string fesil = FesliTap(ay);
Console.WriteLine(ay + "-ci ay " + fesil + " fəsilidir.");
    

     string FesliTap(int ay)
{
    if (ay == 12 || ay == 1 || ay == 2)
    {
        return "qış";
    }
    else if (ay >= 3 && ay <= 5)
    {
        return "yaz";
    }
    else if (ay >= 6 && ay <= 8)
    {
        return "yay";
    }
    else if (ay >= 9 && ay <= 11)
    {
        return "payız";
    }
    else
    {
        return "düzgün ay daxil edin";
    }
}
