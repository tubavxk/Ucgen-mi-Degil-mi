int kenar1, kenar2, kenar3;

Console.WriteLine("1.sayı");
kenar1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2.sayı");
kenar2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("3.sayı");
kenar3 = Convert.ToInt32(Console.ReadLine());

int toplam;
toplam = kenar1 + kenar2 + kenar3;

Console.WriteLine("toplam: ");
Console.Write(toplam);
Console.ReadLine();

if (toplam < 180)
{
    Console.WriteLine("ücgen degil");
}

else if (toplam > 180)
{
    Console.WriteLine("ücgen degil");
}

else
{
    Console.WriteLine("ücgen");
}

Console.ReadKey();