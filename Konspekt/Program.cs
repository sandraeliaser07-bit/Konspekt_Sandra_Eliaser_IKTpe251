// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1. tuvasta sinu võrdluses tühja stringiga, string andmetüüp
Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?");
string nimi = Console.ReadLine();

if (nimi == "")
{
    Console.WriteLine("Sa ei sisestanud oma nime, sadface 😒");
}
else if (nimi != "")
{
    Console.WriteLine("Tere" + nimi + "! happyface 😊"); 
}
else
{
    Console.WriteLine("Tundmatu sisestus.");
}
//2 - vahemikud
Console.WriteLine(nimi + ", mis on sinu vamus?:");
int kasutajavanus = int.Parse(Console.ReadLine());

//2.1 mitu tingimust pesastatud ifide abil
//if (kasutajavanus > 0)
//{
//    if (kasutajavanus < 18)
//    {
//        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😢😢");
//    }
//    else
//    {
//        Console.WriteLine("Yippy! saad monsut osta");
//    }
//}

//2.2 mitu tingimust kasutadesloogilist tehet "and"

    if (kasutajavanus < 18 && kasutajavanus > 0)
    {
        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😢😢");
    }
    else
    {
        Console.WriteLine("Yippy! saad monsut osta");
    }
//2.3 mitu vahemiku if/else-if abil. andmetüüp double/float/decimal
Console.WriteLine($"Sisesta oma pikkus ka {nimi}!");
double kasutajaPikkus = double.Parse(Console.ReadLine());

if (kasutajaPikkus < 1.00d)
{
    Console.WriteLine("Oled juntsu");
}
else if (kasutajaPikkus < 1.25d && kasutajaPikkus >= 1.00d)
{
    Console.WriteLine("Oled peaaegu allameetrimees");
}
else if (kasutajaPikkus < 1.50d && kasutajaPikkus >= 1.25d)
{
    Console.WriteLine("oioi, päkapikk enam ei olegi"+nimi);
}
else if (kasutajaPikkus < 1.75d && kasutajaPikkus >= 1.5d)
{
    Console.WriteLine(nimi+", oled enamasti standardpikkuses, kui mitte just natuke lühike");
}else if (kasutajaPikkus < 2.00d && kasutajaPikkus >= 1.75d)
{
    Console.WriteLine(nimi+", oled pikk kolge, vaata et sa pead vastu uksepiita ära ei löö");
}
else
{
    Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad lähedalt?");
}
//3. kalkulaator ifi ja else-ifiga, int ja string andmetüübid

int arv1 = 0;
    int arv2 = 0;
    Console.WriteLine("Sisesta arv 1");
arv1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Sisesta arv 2");
arv2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Millist tehet soovite teha? + - / * ^");
string tehtetüüp = Console.ReadLine();
    float tulemus = 0;
if (tehtetüüp == "+")
{
    tulemus = arv1 + arv2;
}
if (tehtetüüp == "-")
{
    tulemus = arv1 - arv2;
}
if (tehtetüüp == "/")
{
    tulemus = arv1 / arv2;

}
if (tehtetüüp == "*")
{
    tulemus = arv1 * arv2;

}
if (tehtetüüp == "^")
{
    tulemus = (float)Math.Pow(arv1, arv2);
}
Console.WriteLine(tulemus);

//4. parool, if ja string andmetüüp
Console.WriteLine($"Palun vabandust {nimi}, aga programmi edasiseks tööks on vaja parooli");
string password = Console.ReadLine();
if (password  == "simsalabim")
{
    Console.WriteLine("Parool on õige");
}
else if (password == "saatana" || password == "1234")
{
    Console.WriteLine("Parool on sobimatu");
}
else
{
    Console.WriteLine("Parool on vale");
}

//5. värvituvastus
Console.WriteLine("Mis on sinu lemmikvärv?:");
string favColour = Console.ReadLine(); 
if (favColour == "punane")
{
    Console.BackgroundColor = ConsoleColor.Red;
}
else if (favColour == "roheline")
{
    Console.BackgroundColor = ConsoleColor.Green;
}
else if (favColour == "kollane")
{
    Console.BackgroundColor = ConsoleColor.Yellow;
}
else if (favColour == "sinine")
{
    Console.BackgroundColor = ConsoleColor.Blue;
}
else if (favColour == "must")
{
    Console.BackgroundColor = ConsoleColor.Black;
}
else if (favColour == "valge")
{
    Console.BackgroundColor = ConsoleColor.White;
}
else if (favColour == "hall")
{
    Console.BackgroundColor = ConsoleColor.Gray;
}
else if (favColour == "tumesinine")
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
}
else if (favColour == "tumeroheline")
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
}
else if (favColour == "helesinine")
{
    Console.BackgroundColor = ConsoleColor.Cyan;
}
else if (favColour == "pruun")
{
    Console.BackgroundColor = ConsoleColor.DarkYellow;
}
else if (favColour == "oranz")
{
    Console.WriteLine("Oranzi pole saadaval");
}else if (favColour == "lilla")
{
    Console.WriteLine("lilat pole saadaval");
}

else if (favColour == "roosa")
{
    Console.BackgroundColor = ConsoleColor.Magenta;
}
else
{
    Console.WriteLine("Ei tea seda värvi");
}
    Console.WriteLine("The colour maybe has changed");
