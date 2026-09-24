List<int> bevetel = new List<int>();
Console.WriteLine("=== Kávézó Heti Bevételek Rögzítése ===");
for  (int i = 0; i < 5; i++)
{
    Console.Write($"{i + 1}. nap bevétele (Ft)");
    int napi=int.Parse( Console.ReadLine() );
    bevetel.Add(napi);
}
int osszeg = 0;
for  (int i = 0;i < 5;i++)
{
    osszeg += bevetel[i];
}
double atlag = osszeg / 5.0;
string statusz;
if (atlag>=80000)
{
    statusz ="Kiemelkedő hét!";
}
else if (atlag>=50000)
{
    statusz = "Átlagos hét.";
}
else
{
    statusz = "Gyenge hét, felülvizsgálat szükséges!";
}
Console.WriteLine("Adatok feldolgozása...");
Console.WriteLine("========================================");
Console.WriteLine("Rögzített napi bevételek:");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"\t- {i + 1}. nap: {bevetel[i]}Ft");
}
Console.WriteLine("----------------------------------------");
Console.WriteLine($"Összesített bevétel:{osszeg} Ft");
Console.WriteLine($"Napi átlagbevétel:{atlag} Ft");
Console.WriteLine($"Heti státusz: {statusz}");
Console.WriteLine("========================================");