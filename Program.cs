List<string> Kahveler = new List<string>();
Console.WriteLine("Lutfen 5 adet kahve turu giriniz.");
for(int i=1;i<6;i++)
{
    Console.Write("Kahve {0}= ",i);
    Kahveler.Add(Console.ReadLine());
}
Console.WriteLine("Girilen kahve isimleri");
foreach(string kahve in Kahveler)
{
    Console.WriteLine(kahve);
}
