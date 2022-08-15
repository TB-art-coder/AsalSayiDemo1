Console.Write("Sayı: ");
int giris = Convert.ToInt32(Console.ReadLine());
bool asalMi = true;
for (int sayi = 2; sayi < giris && asalMi; sayi++)
{
    if(giris % sayi == 0)
    {
        asalMi = false;
        
    }
}
if (asalMi)
    Console.WriteLine("Asal");
else
    Console.WriteLine("Asal Değil");


for (int i = 65 ;i <= 90; i++)
{
    Console.WriteLine(Convert.ToChar(i));
}
for (char k = 'A'; k <= 'Z'; k++)
{
    Console.WriteLine(k);
}

for (char k = 'A'; k <= 'z'; k++)
{
    Console.WriteLine(Convert.ToChar(k));
    
}

for (char k = 'A';  k <= 'z';  k++) // A dan Z ye büyük ve küçük harflerle yazma
{
    if ((k >= 'A' && k <= 'Z') || (k >= 'a' && k <= 'z'))
        Console.Write(k + " ");
}
Console.WriteLine();

int fark = 'a' - 'A'; // A ile a arasındaki fark 32ymiş bu kodla bulduk
Console.WriteLine(fark);

for (char k = 'A'; k <= 'Z'; k++)
{
    Console.Write(k + " " + (char)(k + 32) + " ");
}


