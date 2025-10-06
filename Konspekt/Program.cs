// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

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
//Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
//mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga
arv1 = int.Parse(Console.ReadLine());
// Anname teada, et kood loeks mis on kasutaja sisestatud arv1, funktsiooniga "Console". Lause õpeb lauselõpumrägiga
    Console.WriteLine("Sisesta arv 2");
//Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
//mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga
arv2 = int.Parse(Console.ReadLine());
// Anname teada, et kood loeks mis on kasutaja sisestatud arv2, funktsiooniga "Console ja ReadLine". Lause lõpeb lauselõpumärgiga
Console.WriteLine("Millist tehet soovite teha? + - / * ^");
//Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum. Lause lõpeb lauselõpumärgiga
string tehtetüüp = Console.ReadLine();
//Tekitame muutuja "tehtetüüp", mille ette paneme andmetüübiks string ehk ütleme et seal on tekst, ning võrdusmärgi abil omistame talle
// konsool rea pealt loetlu info , mis saame kasutades "Console" mooduli, ReadLine() funktsiooni. Lause lõpeb lauselõpumärgiga.
    float tulemus = 0;
//Funktsioon float näitab et tulemus võib tulla kümnendsüsteemis olev ujukomaga arv. Lauselõpumärgiga
if (tehtetüüp == "+")
//Kasutame ifi et öelda "Kui on nii siis on nii" ehk siis tingimus.Tingimuse muutuja on tehtetüüp ja selle sisu on sõne "-". Kasutame sulupaari, et hoida sees olevat infot ja "", mille sees on tekst
{
    tulemus = arv1 + arv2;
    //tulemus on Liitmistehe muutuja arv1 ja arv 2 vahel. Lause lõppeb lõpumärgiga
}
// Pärast tingimust on koodiplokk {}. Koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtrus jagades
// muutuja arv1 muutujaga arv2. Lause lõppeb lauselõpumärgiga
if (tehtetüüp == "-")
//Kasutame ifi et öelda "Kui on nii siis on nii" ehk siis tingimus. Tingimuse muutuja on ja selle sisu on "-". tehtetüüp Kasutame sulupaari, et hoida sees olevat infot
{
    tulemus = arv1 - arv2;
//Tulemus on Lahutamistehe muutuja arv1 ja arv 2 vahel. Lause lõppeb lõpumärgiga
}
if (tehtetüüp == "/")
//Kasutame ifi et öelda "Kui on nii siis on nii" ehk siis tingimus. Tingimuse muutuja on tehtetüüp ja selle sisu on "-" Kasutame sulupaari, et hoida sees olevat infot ja "", mille sees on tekst.
{
    tulemus = arv1 / arv2;
    //Tulemus on jagamistehe muutuja arv1 ja arv 2 vahel. Lause lõppeb lauselõpumärgiga

}
if (tehtetüüp == "*")
//Kasutame ifi et öelda "Kui on nii siis on nii" ehk siis tingimus.(tingimuse muutuja on tehtetüüp) Kasutame sulupaari, et hoida sees olevat infot ja "", mille sees on tekst
{
    tulemus = arv1 * arv2;
    //Tulemus on korrutamistehe muutuja arv1 ja arv 2 vahel. Lause lõppeb lauselõpumärgiga
}
if (tehtetüüp == "^")
//Kasutame ifi et öelda "Kui on nii siis on nii" ehk siis tingimus.(tingimuse muutuja on tehtetüüp) Kasutame sulupaari, et hoida sees olevat infot ja "", mille sees on tekst
{
    tulemus = (float)Math.Pow(arv1, arv2);
    //Tulemus on astendamine muutuja arv1 ja arv 2 vahel, kasutades moodulist "Math" punkti abil funktsiooni "Pow()" Lause lõppeb lauselõpumärgiga
}
Console.WriteLine(tulemus);
// Kasutame Console ja WriteLine et anda kasutajale sõnum, sulgude sees näitab, milline sõnum antakse. Lause lõpeb lauselõpumärgiga

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

//#ISESEISEV ÜLEASANNE!!!
//# Kolija kalkulaator - Kirjuta programm mis:
//# - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
//# - olenevalt kasutaja sisestusest küsib ta:
//# - - tünni jaoks:
//# - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
//# - - - tünni kõrgust
//# - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
//# - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
//# - - kasti jaoks:
//# - - - Kas kast on kuubiku kujuline või risttahuka kujuline
//# - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
//# - - - - kui on risttahukas siis küsib kasutajalt:
//# - - - - - pikima külje pikkust,
//# - - - - - lühima külje pikkust ja
//# - - - - - kasti kõrgust
//# - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)
Console.WriteLine("Kas sa tahad mõõta ära kasti või tünni?");
string valik = Console.ReadLine();
if (valik == "tünn") 
{
    Console.WriteLine("Kas sa tead tünni raadiust (r) või läbimõõtu (d)");
    string rvõid = Console.ReadLine();
    Console.WriteLine("Sisesta see mõõt");
    double mõõt = double.Parse(Console.ReadLine());
    if (rvõid == "d")
    {
        mõõt = mõõt / 2;
    }
    else if (rvõid != "r")
    {
        Console.WriteLine("Sisend ei ole tuntav");
    }
    Console.WriteLine("Kui kõrge on su tünn");
    int kõrgus = int.Parse(Console.ReadLine());
    Console.WriteLine("Kui paks on tünni kaas?");
    int kaanepaksus = int.Parse(Console.ReadLine());
    double tünnipõhiS = Math.PI + (mõõt * mõõt);
    double mahtV = tünnipõhiS * (kõrgus - kaanepaksus);
    double küljepindala = tünnipõhiS * kõrgus;
    double kogupindala = (tünnipõhiS * 2) + küljepindala;
    Console.WriteLine($"Sinu tünn mahutab {mahtV}\nTünni küljepindala on {küljepindala} \nKogupindala aga on {kogupindala}");
} 

else if (valik == "kast")
{
    Console.WriteLine("Kas su kast on kuubik (k) või risttahukas (r) ?");
    string kastitüüp = Console.ReadLine();
    if (kastitüüp == "k")
    {
        Console.WriteLine("Sisesta kasti küljepikkus");
        double külgA = double.Parse(Console.ReadLine());
        double kuubik = Math.Pow(külgA, 3);
        double küljepindala = (külgA * külgA) * 6;
        double diagonaal = külgA * Math.Sqrt(3);
        Console.WriteLine($"Sinu kuubik mahutab {kuubik}\nKuubiku küljepindala on {küljepindala} \nDiagonaal aga on {diagonaal}");
    }
    else if (kastitüüp == "r")
    {
        Console.WriteLine("Mis onj sinu kasti kõige pikim külg?");
        double pikkkülg = double.Parse(Console.ReadLine());
        Console.WriteLine("Mis onj sinu kasti kõige lühim külg?");
        double lühimkülg = double.Parse(Console.ReadLine());
        Console.WriteLine("Mis onj sinu kasti kõrgus?");
        double kõrgus = double.Parse(Console.ReadLine());
        double V = pikkkülg * lühimkülg * kõrgus;
        double kogupindala = 2 * ((pikkkülg * lühimkülg) + (lühimkülg * kõrgus) + (pikkkülg * kõrgus));
        double diagonaal = Math.Sqrt((pikkkülg * pikkkülg) + (lühimkülg * lühimkülg) + (kõrgus * kõrgus));
        Console.WriteLine($"Sinu kast mahutab {V}\nKasti küljepindala on {kogupindala} \nDiagonaal aga on {diagonaal}");

    }
}

Console.WriteLine("Banana");
// Console -> adresseritav moodu või objekt (roheline)
// . -> midagi selle objekti seest, sarnane windowsi kausta pathis oleva slashiga
// WriteLine -> adresseritav funktsioon objektist Console
// () -> sulupaar, mis omab endas funktsioonile vajalikku infot
//   - saab kasutada ka if tingimuslauses oleva tingimuse piiramiseks, ehk teisisõnu "ifi parameeter"
// kasutatakse ka matemaatilistest tehetes
// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
//   - saab ka kasutada teksti sees muutujate kuvamiseks
// _ -> taane aitab arendajal aru saada millise koodiploki sees, miski on. Vajalik ka kompilaatorile
//"banana" -> parameeter, mis antakse funktsioonile WriteLine töötle,miseks kaasa.
// ; -> iga koodlause lõppeb komakooloniga

int muutuja = 3;
// int -> muutuja nime ees olev andmetüübi kirjeldus. See näitab ära, millist tüüpi andmed selle muutuja sees on
// istantseerimime muutuja tulemus, mille andmetüübiks on int, ja omistame talle esialgu väärtuse 
// = -> võrdusmärk omistab sellele muutujale mingusuguse väärtuse
// 3 -> väärtus, mis sellele muutujale omistatakse

//võimalikud andmetüübid:
int a = 1; // täisarv
decimal b = 2.0M; // kümnendsüsteemis olev komakohaga arv
float c = 3.0f; // kümnendsüsteemis olev ujukomaga arv
double d = 4.0d; // kümnendsüsteemis olev komakohaga arv, saame decimaliga
char c1 =
string s = "tekst"; // inimloetavalt kujul tekst
var x =  "abc"; // ebamäärase tüübiga kohalik muutuja
var y = 123;
const int z = 3; //konstant-tüüpi muutujaid ei saa muuta, need on read-only

//põhilised matemaatilised tehted
int liitmine = 1 + 1; //liitmine, kaks arvu kokku
int lahutamine = 1 - 1; // lahutamine, esimene arv teisest maha
int korrutamine = 1 * 1; // korrutamine, esimene arv teisega
int jagamine = 1 / 1; // jagamine, esimene arv teisega
double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
double juurimine = Math.Sqrt(2); //ruutjuur, parameetriks arv mida juuritakse

int arv = 0; //sobib
string sõne = "abc"; //sobib
string sisend_string = "abc"; //sobib
//string string //ei sobi

//muutuja nimeks ei sobi järgnevad sõnad:
//abstract, as, base, bool, break, byte, case,
//catch, char, checked, class, const,continue, decimal,
//default, delegate, do, double, else, event,
//explict, external, false, finally, fixed, dloat, for
//foreach, goto, if, implicit, in, int
//interface, internal, is, lock, long, namespace, new
//null, object, operator, out, override, params,
//private, protected, public, readonly, ref, return, sbyte
//sealed, short, sizeef, stackalloc, static, string,struct
//switch, this,throw, true, try, typeof, uint,
//ulong, unchecked, unsafe, ushort, using, virtual, void
//volatile, while.

