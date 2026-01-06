//using System.ComponentModel.Design;

//Console.WriteLine("Hello, World!");
////1. tuvasta sinu võrdluses tühja stringiga, string andmetüüp
//Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?");
//string nimi = Console.ReadLine();

//if (nimi == "")
//{
//    Console.WriteLine("Sa ei sisestanud oma nime, sadface 😒");
//}
//else if (nimi != "")
//{
//    Console.WriteLine("Tere" + nimi + "! happyface 😊"); 
//}
//else
//{
//    Console.WriteLine("Tundmatu sisestus.");
//}
////2 - vahemikud
//Console.WriteLine(nimi + ", mis on sinu vamus?:");
//int kasutajavanus = int.Parse(Console.ReadLine());

////2.1 mitu tingimust pesastatud ifide abil
////if (kasutajavanus > 0)
////{
////    if (kasutajavanus < 18)
////    {
////        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😢😢");
////    }
////    else
////    {
////        Console.WriteLine("Yippy! saad monsut osta");
////    }
////}

////2.2 mitu tingimust kasutadesloogilist tehet "and"

//    if (kasutajavanus < 18 && kasutajavanus > 0)
//    {
//        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😢😢");
//    }
//    else
//    {
//        Console.WriteLine("Yippy! saad monsut osta");
//    }
////2.3 mitu vahemiku if/else-if abil. andmetüüp double/float/decimal
//Console.WriteLine($"Sisesta oma pikkus ka {nimi}!");
//double kasutajaPikkus = double.Parse(Console.ReadLine());

//if (kasutajaPikkus < 1.00d)
//{
//    Console.WriteLine("Oled juntsu");
//}
//else if (kasutajaPikkus < 1.25d && kasutajaPikkus >= 1.00d)
//{
//    Console.WriteLine("Oled peaaegu allameetrimees");
//}
//else if (kasutajaPikkus < 1.50d && kasutajaPikkus >= 1.25d)
//{
//    Console.WriteLine("oioi, päkapikk enam ei olegi"+nimi);
//}
//else if (kasutajaPikkus < 1.75d && kasutajaPikkus >= 1.5d)
//{
//    Console.WriteLine(nimi+", oled enamasti standardpikkuses, kui mitte just natuke lühike");
//}else if (kasutajaPikkus < 2.00d && kasutajaPikkus >= 1.75d)
//{
//    Console.WriteLine(nimi+", oled pikk kolge, vaata et sa pead vastu uksepiita ära ei löö");
//}
//else
//{
//    Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad lähedalt?");
//}
////3. kalkulaator ifi ja else-ifiga, int ja string andmetüübid

////int arv1 = 0;
////    int arv2 = 0;
////    Console.WriteLine("Sisesta arv 1");
//////Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
//////mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga
////arv1 = int.Parse(Console.ReadLine());
////// Anname teada, et kood loeks mis on kasutaja sisestatud arv1, funktsiooniga "Console". Lause õpeb lauselõpumrägiga
////    Console.WriteLine("Sisesta arv 2");
//////Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
//////mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga
////arv2 = int.Parse(Console.ReadLine());
////// Anname teada, et kood loeks mis on kasutaja sisestatud arv2, funktsiooniga "Console ja ReadLine". Lause lõpeb lauselõpumärgiga
////Console.WriteLine("Millist tehet soovite teha? + - / * ^");
//////Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum. Lause lõpeb lauselõpumärgiga
////string tehtetüüp = Console.ReadLine();
//////Tekitame muutuja "tehtetüüp", mille ette paneme andmetüübiks string ehk ütleme et seal on tekst, ning võrdusmärgi abil omistame talle
////// konsool rea pealt loetlu info , mis saame kasutades "Console" mooduli, ReadLine() funktsiooni. Lause lõpeb lauselõpumärgiga.
////    float tulemus = 0;
//////Funktsioon float näitab et tulemus võib tulla kümnendsüsteemis olev ujukomaga arv. Lauselõpumärgiga
////if (tehtetüüp == "+")
//////Kasutame ifi et öelda "Kui on nii siis on nii" ehk siis tingimus.Tingimuse muutuja on tehtetüüp ja selle sisu on sõne "-". Kasutame sulupaari, et hoida sees olevat infot ja "", mille sees on tekst
////{
////    tulemus = arv1 + arv2;
////    //tulemus on Liitmistehe muutuja arv1 ja arv 2 vahel. Lause lõppeb lõpumärgiga
////}
////// Pärast tingimust on koodiplokk {}. Koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtrus jagades
////// muutuja arv1 muutujaga arv2. Lause lõppeb lauselõpumärgiga
////if (tehtetüüp == "-")
//////Kasutame ifi et öelda "Kui on nii siis on nii" ehk siis tingimus. Tingimuse muutuja on ja selle sisu on "-". tehtetüüp Kasutame sulupaari, et hoida sees olevat infot
////{
////    tulemus = arv1 - arv2;
//////Tulemus on Lahutamistehe muutuja arv1 ja arv 2 vahel. Lause lõppeb lõpumärgiga
////}
////if (tehtetüüp == "/")
//////Kasutame ifi et öelda "Kui on nii siis on nii" ehk siis tingimus. Tingimuse muutuja on tehtetüüp ja selle sisu on "-" Kasutame sulupaari, et hoida sees olevat infot ja "", mille sees on tekst.
////{
////    tulemus = arv1 / arv2;
////    //Tulemus on jagamistehe muutuja arv1 ja arv 2 vahel. Lause lõppeb lauselõpumärgiga

////}
////if (tehtetüüp == "*")
//////Kasutame ifi et öelda "Kui on nii siis on nii" ehk siis tingimus.(tingimuse muutuja on tehtetüüp) Kasutame sulupaari, et hoida sees olevat infot ja "", mille sees on tekst
////{
////    tulemus = arv1 * arv2;
////    //Tulemus on korrutamistehe muutuja arv1 ja arv 2 vahel. Lause lõppeb lauselõpumärgiga
////}
////if (tehtetüüp == "^")
//////Kasutame ifi et öelda "Kui on nii siis on nii" ehk siis tingimus.(tingimuse muutuja on tehtetüüp) Kasutame sulupaari, et hoida sees olevat infot ja "", mille sees on tekst
////{
////    tulemus = (float)Math.Pow(arv1, arv2);
////    //Tulemus on astendamine muutuja arv1 ja arv 2 vahel, kasutades moodulist "Math" punkti abil funktsiooni "Pow()" Lause lõppeb lauselõpumärgiga
////}
////Console.WriteLine(tulemus);
////// Kasutame Console ja WriteLine et anda kasutajale sõnum, sulgude sees näitab, milline sõnum antakse. Lause lõpeb lauselõpumärgiga

////4. parool, if ja string andmetüüp
//Console.WriteLine($"Palun vabandust {nimi}, aga programmi edasiseks tööks on vaja parooli");
//string password = Console.ReadLine();
//if (password  == "simsalabim")
//{
//    Console.WriteLine("Parool on õige");
//}
//else if (password == "saatana" || password == "1234")
//{
//    Console.WriteLine("Parool on sobimatu");
//}
//else
//{
//    Console.WriteLine("Parool on vale");
//}

////5. värvituvastus
//Console.WriteLine("Mis on sinu lemmikvärv?:");
//string favColour = Console.ReadLine(); 
//if (favColour == "punane")
//{
//    Console.BackgroundColor = ConsoleColor.Red;
//}
//else if (favColour == "roheline")
//{
//    Console.BackgroundColor = ConsoleColor.Green;
//}
//else if (favColour == "kollane")
//{
//    Console.BackgroundColor = ConsoleColor.Yellow;
//}
//else if (favColour == "sinine")
//{
//    Console.BackgroundColor = ConsoleColor.Blue;
//}
//else if (favColour == "must")
//{
//    Console.BackgroundColor = ConsoleColor.Black;
//}
//else if (favColour == "valge")
//{
//    Console.BackgroundColor = ConsoleColor.White;
//}
//else if (favColour == "hall")
//{
//    Console.BackgroundColor = ConsoleColor.Gray;
//}
//else if (favColour == "tumesinine")
//{
//    Console.BackgroundColor = ConsoleColor.DarkBlue;
//}
//else if (favColour == "tumeroheline")
//{
//    Console.BackgroundColor = ConsoleColor.DarkGreen;
//}
//else if (favColour == "helesinine")
//{
//    Console.BackgroundColor = ConsoleColor.Cyan;
//}
//else if (favColour == "pruun")
//{
//    Console.BackgroundColor = ConsoleColor.DarkYellow;
//}
//else if (favColour == "oranz")
//{
//    Console.WriteLine("Oranzi pole saadaval");
//}else if (favColour == "lilla")
//{
//    Console.WriteLine("lilat pole saadaval");
//}

//else if (favColour == "roosa")
//{
//    Console.BackgroundColor = ConsoleColor.Magenta;
//}
//else
//{
//    Console.WriteLine("Ei tea seda värvi");
//}
//    Console.WriteLine("The colour maybe has changed");

////#ISESEISEV ÜLEASANNE!!!
////# Kolija kalkulaator - Kirjuta programm mis:
////# - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
////# - olenevalt kasutaja sisestusest küsib ta:
////# - - tünni jaoks:
////# - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
////# - - - tünni kõrgust
////# - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
////# - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
////# - - kasti jaoks:
////# - - - Kas kast on kuubiku kujuline või risttahuka kujuline
////# - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
////# - - - - kui on risttahukas siis küsib kasutajalt:
////# - - - - - pikima külje pikkust,
////# - - - - - lühima külje pikkust ja
////# - - - - - kasti kõrgust
////# - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)
//Console.WriteLine("Kas sa tahad mõõta ära kasti või tünni?");
//string valik = Console.ReadLine();
//if (valik == "tünn") 
//{
//    Console.WriteLine("Kas sa tead tünni raadiust (r) või läbimõõtu (d)");
//    string rvõid = Console.ReadLine();
//    Console.WriteLine("Sisesta see mõõt");
//    double mõõt = double.Parse(Console.ReadLine());
//    if (rvõid == "d")
//    {
//        mõõt = mõõt / 2;
//    }
//    else if (rvõid != "r")
//    {
//        Console.WriteLine("Sisend ei ole tuntav");
//    }
//    Console.WriteLine("Kui kõrge on su tünn");
//    int kõrgus = int.Parse(Console.ReadLine());
//    Console.WriteLine("Kui paks on tünni kaas?");
//    int kaanepaksus = int.Parse(Console.ReadLine());
//    double tünnipõhiS = Math.PI + (mõõt * mõõt);
//    double mahtV = tünnipõhiS * (kõrgus - kaanepaksus);
//    double küljepindala = tünnipõhiS * kõrgus;
//    double kogupindala = (tünnipõhiS * 2) + küljepindala;
//    Console.WriteLine($"Sinu tünn mahutab {mahtV}\nTünni küljepindala on {küljepindala} \nKogupindala aga on {kogupindala}");
//} 

//else if (valik == "kast")
//{
//    Console.WriteLine("Kas su kast on kuubik (k) või risttahukas (r) ?");
//    string kastitüüp = Console.ReadLine();
//    if (kastitüüp == "k")
//    {
//        Console.WriteLine("Sisesta kasti küljepikkus");
//        double külgA = double.Parse(Console.ReadLine());
//        double kuubik = Math.Pow(külgA, 3);
//        double küljepindala = (külgA * külgA) * 6;
//        double diagonaal = külgA * Math.Sqrt(3);
//        Console.WriteLine($"Sinu kuubik mahutab {kuubik}\nKuubiku küljepindala on {küljepindala} \nDiagonaal aga on {diagonaal}");
//    }
//    else if (kastitüüp == "r")
//    {
//        Console.WriteLine("Mis onj sinu kasti kõige pikim külg?");
//        double pikkkülg = double.Parse(Console.ReadLine());
//        Console.WriteLine("Mis onj sinu kasti kõige lühim külg?");
//        double lühimkülg = double.Parse(Console.ReadLine());
//        Console.WriteLine("Mis onj sinu kasti kõrgus?");
//        double kõrgus = double.Parse(Console.ReadLine());
//        double V = pikkkülg * lühimkülg * kõrgus;
//        double kogupindala = 2 * ((pikkkülg * lühimkülg) + (lühimkülg * kõrgus) + (pikkkülg * kõrgus));
//        double diagonaal = Math.Sqrt((pikkkülg * pikkkülg) + (lühimkülg * lühimkülg) + (kõrgus * kõrgus));
//        Console.WriteLine($"Sinu kast mahutab {V}\nKasti küljepindala on {kogupindala} \nDiagonaal aga on {diagonaal}");

//    }
//}

//Console.WriteLine("Banana");
//// Console -> adresseritav moodu või objekt (roheline)
//// . -> midagi selle objekti seest, sarnane windowsi kausta pathis oleva slashiga
//// WriteLine -> adresseritav funktsioon objektist Console
//// () -> sulupaar, mis omab endas funktsioonile vajalikku infot
////   - saab kasutada ka if tingimuslauses oleva tingimuse piiramiseks, ehk teisisõnu "ifi parameeter"
//// kasutatakse ka matemaatilistest tehetes
//// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
////   - saab ka kasutada teksti sees muutujate kuvamiseks
//// _ -> taane aitab arendajal aru saada millise koodiploki sees, miski on. Vajalik ka kompilaatorile
////"banana" -> parameeter, mis antakse funktsioonile WriteLine töötle,miseks kaasa.
//// ; -> iga koodlause lõppeb komakooloniga

//int muutuja = 3;
//// int -> muutuja nime ees olev andmetüübi kirjeldus. See näitab ära, millist tüüpi andmed selle muutuja sees on
//// istantseerimime muutuja tulemus, mille andmetüübiks on int, ja omistame talle esialgu väärtuse 
//// = -> võrdusmärk omistab sellele muutujale mingusuguse väärtuse
//// 3 -> väärtus, mis sellele muutujale omistatakse


//internal class Program
{
    //private static void Main(string[] args)

////võimalikud andmetüübid:
//int a = 1; // täisarv
//decimal b = 2.0M; // kümnendsüsteemis olev komakohaga arv
//float c = 3.0f; // kümnendsüsteemis olev ujukomaga arv
//double d = 4.0d; // kümnendsüsteemis olev komakohaga arv, saame decimaliga
//char c1 =
//string = "tekst"; // inimloetavalt kujul tekst
//var x =  "abc"; // ebamäärase tüübiga kohalik muutuja
//var y = 123;
//const int z = 3; //konstant-tüüpi muutujaid ei saa muuta, need on read-only

//võimalikud komposiitandmetüübid:
// [] -> Massiiv on komposiitandmetüüp, mille sees saab olla mitu samat tüüpi lihtandmeid. Massivi tähistatakse kantsulgudega.
//       Massiive saab olla ükskõik, millist lihtandmetüüpi massiive.
//massiivi tekitamisel tuleb ära öelda kui pikk või suur see massiiv on
//massiiv saab olla koostatud ka teistest massiividest
//
//esimene tekitusviis:
//int[] arvuMassiiv = new int[3]; // andmetüüp int väljendab et tegu on täisarvutüüpi andmega ja kantsulud väljendavad et tegu ühtlasi
//                                // ka massiiviga nimeks on "arvuMasiiv" ja võrdusmärgiga, on esimene tekitusmoodus öelda, et tegu on
//                                // uue massiiviga kasutades kaitstud sõna "new", ja sellele järgneb massiivi pikkuse sätestus "int[3]"
//                                // See tähendab et siin massiivis on 3 elementi, mis on täisarvud

////teine tekitusviis: //teine massiivi tekitusviis, kus järjendi pikkuse sätestamine asemel, pannakse elemendid kohe sisse
//int[] arvuMassiiv2 = [1,2,3];

//// -- massiivi sisemised metoodid:
//int hasthismany = arvuMassiv.Length; // massiivi meetod "Length" mille me saame kasutusele võtta punkti abil, loendab kokku, mitu
                                     //elementi järjendist parasjagu on

////põhilised matemaatilised tehted
//int liitmine = 1 + 1; //liitmine, kaks arvu kokku
//int lahutamine = 1 - 1; // lahutamine, esimene arv teisest maha
//int korrutamine = 1 * 1; // korrutamine, esimene arv teisega
//int jagamine = 1 / 1; // jagamine, esimene arv teisega
//double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
//double juurimine = Math.Sqrt(2); //ruutjuur, parameetriks arv mida juuritakse

//int arv = 0; //sobib
//string sõne = "abc"; //sobib
//string sisend_string = "abc"; //sobib
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

Console.WriteLine("Sisesta ostusumma");
//Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale kuvada tekst, sulgude sees ja jutumärkide vahel. Lause lõpeb lauselõpumärgiga.
double ostusumma = double.Parse(Console.ReadLine());
//Kasutame double et ostusumma võib olla kümnendsüsteemis olev komakohaga arv. Kasutame double.Parse et teisendada määratud stiilis arvu stringesituse selle kahekordse täpsusega ujukomaarvu ekvivalendiks.  
if (ostusumma > 100)
//Kasutame ifi ehk tingimust, et anda teada sulgude sees, kus hoiame muutujat on vsuurem kui 100.
{
//Pärast tingimust on koodiplokk {}.
    Console.WriteLine("Saad 20% allahindlust!");
//Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale kuvada tekst, sulgude sees ja jutumärkide vahel. Lause lõpeb lauselõpumärgiga.
 }
else if (ostusumma < 101 && ostusumma > 50)
// Kasutame tingimust else if, et sulgude sees olev muutuja on väiksem kui 101. See imelik märk näitab, kas mõlemad operandid on tõessed. Näitab et muutuja on suurem kui 50
{
//Pärast tingimust on koodiplokk {}.
    Console.WriteLine("Saad 10% allahindlust!");
 //Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale kuvada tekst, sulgude sees ja jutumärkide vahel. Lause lõpeb lauselõpumärgiga.
    }
else if (ostusumma < 51 && ostusumma > 20)
// Kasutame tibgimust else if, et sulgude sees olev muutuja on väiksem, kui 51. Imelik märk näitab kas mõlemad operandid on tõessed. Muutuja on suurem kui 20.
{
//Pärast tingimust on koodiplokk {}.
    Console.WriteLine("Saad 5% allahindlust!");
 //Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale kuvada tekst, sulgude sees ja jutumärkide vahel. Lause lõpeb lauselõpumärgiga.
    }
else if (ostusumma < 21 )
//Kasutame tingimust else if, et sulgude sees olev muutuja on väiksem kui 21
{
//Pärast tingimust on koodiplokk {}.
    Console.WriteLine("Allahindlust ei saa :(");
 //Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale kuvada tekst, sulgude sees ja jutumärkide vahel. Lause lõpeb lauselõpumärgiga.
    }
    else if (ostusumma <1)
//Kasutame tingimust else if, et kui sulgude sees olev muutuja on väiksem, kui 1
{
//Pärast tingimust on koodiplokk {}.
    Console.WriteLine("Sisestatud vigane arv");
        //Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale kuvada tekst, sulgude sees ja jutumärkide vahel. Lause lõpeb lauselõpumärgiga.
    }

//Console.WriteLine("Palun sisesta oma kasutajanimi");
//string kasutajanimi = "";
//do
//{
//    kasutajanimi = Console.ReadLine();
//}
//while (kasutajanimi != "user1");
//if (kasutajanimi == "user1")
//{
//    int ruudusuurus = 0;

//    do

//    {
// ////võimalikud andmetüübid:
// int a = 1; // täisarv
// decimal b = 2.0M; // kümnendsüsteemis olev komakohaga arv
// float c = 3.0f; // kümnendsüsteemis olev ujukomaga arv
// double d = 4.0d; // kümnendsüsteemis olev komakohaga arv, saame decimaliga
///* char c1 =/ string*/ = "tekst"; // inimloetavalt kujul tekst
// var x = "abc"; // ebamäärase tüübiga kohalik muutuja/var y = 123;
// const int z = 3; //konstant-tüüpi muutujaid ei saa muuta, need on read-only
//void on adnmetüüp, mida muutujale anda ei saa. void on adnmetüüpm mida kasutatakse meetodite jms
//signatuurideks, et näidata tagastatava andmetüübi puudumist. Tegemist on - sõna otseses mõttes - mitte millelgagi

//võimalikud komposiitandmetüübid:
// [] -> Massiiv on komposiitandmetüüp, mille sees saab olla mitu samat tüüpi lihtandmeid. Massivi tähistatakse kantsulgudega.
//       Massiive saab olla ükskõik, millist lihtandmetüüpi massiive.
//massiivi tekitamisel tuleb ära öelda kui pikk või suur see massiiv on
//massiiv saab olla koostatud ka teistest massiividest
//
//esimene tekitusviis:
//int[] arvuMassiiv = new int[3]; // andmetüüp int väljendab et tegu on täisarvutüüpi andmega ja kantsulud väljendavad et tegu ühtlasi
//                                // ka massiiviga nimeks on "arvuMasiiv" ja võrdusmärgiga, on esimene tekitusmoodus öelda, et tegu on
//                                // uue massiiviga kasutades kaitstud sõna "new", ja sellele järgneb massiivi pikkuse sätestus "int[3]"
//                                // See tähendab et siin massiivis on 3 elementi, mis on täisarvud

////teine tekitusviis: //teine massiivi tekitusviis, kus järjendi pikkuse sätestamine asemel, pannakse elemendid kohe sisse
//int[] arvuMassiiv2 = [1, 2, 3];

// -- massiivi sisemised metoodid:
/* int hasthismany = arvuMassiv.Length;*/ // massiivi meetod "Length" mille me saame kasutusele võtta punkti abil, loendab kokku, mitu
                                          //elementi järjendist parasjagu on

////põhilised matemaatilised tehted
//int liitmine = 1 + 1; //liitmine, kaks arvu kokku
//int lahutamine = 1 - 1; // lahutamine, esimene arv teisest maha
//int korrutamine = 1 * 1; // korrutamine, esimene arv teisega
//int jagamine = 1 / 1; // jagamine, esimene arv teisega
//double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
//double juurimine = Math.Sqrt(2); //ruutjuur, parameetriks arv mida juuritakse

//int arv = 0; //sobib
//string sõne = "abc"; //sobib
//string sisend_string = "abc"; //sobib
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

//Console.WriteLine("Sisesta ostusumma");
////Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum. Lause lõppeb lauselõpumärgiga.
//double ostusumma = double.Parse(Console.ReadLine());
////Kasutame double et teada anda et ostusumma võib olla kümnendsüsteemis olev komakohaga arv.  
//if (ostusumma > 100)
////Kasutame ifi ehk tingimust, et anda teada et kui sulgude sees muutuja on suurem kui 100.
//{
//    Console.WriteLine("Saad 20% allahindlust!");
//    //Kasutame funktsiooni Console ja WriteLine et kood kuvaks teksti mis on sulgude sees. Lause lõppeb lauselõpumärgiga
//}
////Pärast tingimust on koodiplokk {}.
////
//else if (ostusumma < 101 && ostusumma > 50)
//{
//    Console.WriteLine("Saad 10% allahindlust!");
//}
//else if (ostusumma < 51 && ostusumma > 20)
//{
//    Console.WriteLine("Saad 5% allahindlust!");
//}
//else if (ostusumma < 21)
//{
//    Console.WriteLine("Allahindlust ei saa :(");
//}
//else if (ostusumma < 1)
//{
//    Console.WriteLine("Sisestatud vigane arv");
//}

//Console.WriteLine("Palun sisesta oma kasutajanimi");
//string kasutajanimi = "";
//do
//{
//    kasutajanimi = Console.ReadLine();
//}
//while (kasutajanimi != "user1");
//if (kasutajanimi == "user1")
//{
//    int ruudusuurus = 0;

//    do
//    {
//        Console.WriteLine("Kui suurt ruutu tahad?");
//        ruudusuurus = int.Parse(Console.ReadLine());
//    } while (ruudusuurus < 0 && ruudusuurus > 20);
//    char reakujund = '█';
//    string üksrida = "";
//    int tsüklimuutuja = ruudusuurus;
//    do
//    {
//        üksrida += reakujund;
//        tsüklimuutuja += 1;
//    } while (tsüklimuutuja != 0);
//    tsüklimuutuja = ruudusuurus;
//    do
//    {
//        Console.WriteLine(üksrida);
//        tsüklimuutuja -= 1;
//    } while (tsüklimuutuja != 0);
//    Console.WriteLine($"Palun, siin on sinu ruut, suurusega {ruudusuurus}x{ruudusuurus}");
//}
///* tingimuslause osad */
//if (true) { } //katstud sõna if kutsub esile tingimuslause, mille tingimus on sulgude vahel, ning millele järgneb
//              //koodiplokk tingimuse täitumisel teostava koodiga
//else if (true) { } //kaitstud sõnad else ja if (else if) kutsuvad esile sekundaarse tingimuslause, mille tingimus
//                   //on samamoodi sulgude vahel, ning millele peab eelnema alati if või else if. Tingimuse täitmisel
//                   //ja eelneva tingimuse mittetäitmisel teostatakse koodiploki sees olev kood
//else { } // kaitstud sõna else kutsub esile järeltingimuse, millele peab eelnema kas if või else if, ning mille koodi-
//ploki sisu täidetakse kõikide if ja else if sees olevate tingimuste läbikukkumisel.

/*loogilised tehted*/
// && "and" -> loogilin ethe mida kasutatakse tingimuse kirjutamisel, ning mis annab positiivse vastuse (true9 juhul kui
//       mõlemal pool && märki olevad tingimused on täidetud. Kui üks neist ei ole, siis annab negatiivse vastuse (false)
// || "or" -> loogilin etehe, mida kasutatakse tingimuse kirjeldamisel, ning mis annab positiivse vastuse (true) siis kui
//       vähemalt üks tingimus on täidetud. False tagastatakse siis, kui kõik tingimuse on täitmata
// ! "not" ->  loogiline tehe, mida kasutatakse tingimuse tulemuse inverteerimiseks. Tulemus mis muidu tagastaks true, hüüumärgi
//       puhul tagastab false, ja vastupidi -tingimus mis muidu tagastab false, hüüumärgi puhul tagastab true

/* Võrduseoperaatorid */
// == -> on võrdne. Võrdusmärkide ühel pool olev objekt peab vastama täpselt oma olemuselt võrdusmärgi teisel pool oleva objektiga
//       ei olw sama nagu 1 võrdusmärk. Üks võrdusmärk omistab 2 kaks võrdleb,
// != -> ei ole võrdne. Võrdusmärgi ühel pool olev objekt ei tohi olla samal kujul nagu teisel pool oleval objekt
//       võrdusoperaator on kombinatsioon on võrdne operaatorist ja loogilisest tehtest not
// > ->ons suurem kui märgist vaskaul pool olev objekt peaks olema suurem kui paremal pool olev objekt.
// > -> on väiksem kui märgist  vaskul pool olev objekt peaks olema väiksem kui paremal pool olev objekt
// >= -> on suurem kui või võrdne kui. Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või suurem
//       kui paremal pool olev objekt. Operaatori on kombinatsioon "on võrdne" ja on "suurem kui" operaatoritest.
// <= -> ov väiksem kui võrdne Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem
//        kui paremal pool olev objekt. Operaatori on kombinatsioon "on võrdne" ja on "väiksem kui" operaatoritest.

/*Omistusoperaatirud ja kiirtehted */
//    int arv = 1;// = -> üksik võrdusmärk omistab muutujale väärtuse.
//    arv += 1;// += -> võrdusmärk, mille ees on plus, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu
//             //                asendab tehet "arv" = arv + 1" on kombinatsioon matemaatilisest tehtest "+" ja omistamisest ("+")
//    arv -= 1; // -= -> võrdusmärk, mille ees on miinus automaatselt lahutab muutujast maha võrdusmärgi teisel pool oleva väärtuse
//              //       asendab tehet "arv = arv - 1" on kombinatsioon matemaatilisest tehtest "-" ja omistamisest ("-")
//    arv *= 2; // *= -> võrdusmärk, mille ees on kordusmärk, automaatselt korrutab muutuja sisu võrdusmärgi teisel pool oleva
//              //                           arvu kordi. asendab tehet "arv *2" on kombinatsioon matemaatilsest tehtest "/" ja omistamisest ("=")
//    arv++; // ++ -> on spetsiifiliselt ühe juurde liitmiseks lühivariant.
//    arv--; //                                        lahutamiseks
//           //*Tsüklid*/
//    do //"do" on kaitstud sõna, mis alustab do-while tsüklit pärast mida on koodiplokk, ning ütleb et tee seda koodi.
//    {

//    } while (true); //niikaua kuni while järel tingimus on täidetud.

//    // 3. for
//    int kogus = 6; //muutuja, mida tsükkel kasutab töötlemiseks mingisugusel kujul
//    for (int k = 0; k < kogus; k++) //kaitstud sõna "for" alustab for tsüklit, pärast mida on sulud, mille vahel on kõik tsükli töö jaoks vajalik info
//                                    // esimene parameeter tekitab tsükli jaoks muutuja, teine parameeter on tingimus lause
//                                    // mis kontrollib tingimuse täitumist ning kolmas inkrementeerib tekitatud
//                                    //muutujat "k++;" pane tähele et iga sulgude vahel oleva osa järel on lauselõpumärk. Tsükli
//                                    // kontrolliv tingimuslause koosneb kolmest reast, mitte ühest, nagu while, või do-while
//                                    //koodiplokk kus theakse mingi  tegevus
//                                    //antud juhul tegevuseks on muutuja "k" arvu väljakuvamine
//    {
//        Console.WriteLine(k);
//    }
////}
/*meetodid*/

//Meetodid on väljakutsutavad koodijupid. Meetodid teostavad tavaliselt mingeid funktsioone või tegevust.
//Meetodid lasevad programeerijal taaskasutada oma eelnevalt kirjutatud koodi - write once many times.
//Meetodid on kahte liiki - ühed, mis tagastavad andmeid mingisuguse töö tulemina, ja teised, mis ei tagasta
//midagi, kuid omavad mingit tegevust.

//Meetodi signatuur:
//Meetodi signatuur koosneb mitmest kindalt äramääratud omadusest, nendeks on:
// -Juurdepääsu modifikaator, mis ütleb ära, kust ja kuidas sellele meetodile juurde pääseda saab
// public - meetod on avalik ja kättesaadav ka teistes klassides peale selle, kus meetod ise asub.
// private - meetod on saadav ainult selles klassis, kus meetod ise asub.
// protected- meetod on saadaval ainult selles klassis, kus meetod ise asub ja kõikides klassides, millel on pärilus
// sellele klassile
// internal- meetod on saadav ainult selles klassis ja ainult selles failis.
//- võib olla ka pandud static - meetod kuulub selle klassi juurde
// - Tgastustüüp on odifikaator, mis ütleb ära, mis tüüpi andmeid meetod tagasi annab, kutsumise asukohta
// Andmetüüp mida tagastada võib olla ükskõik, milline liht või kompinatsioon andmetüüp, aga kui meetod ei tagasta
// üldse andmeid, pannakse selle asemel andmetüübiks "void". Kui meetodil on tagastustüüp mis on midagi muud kui
//void, on meetodi sees, iga toimiva koodisuuna lõpus, kaitstud sõna "return", return ütleb, et just seee, on vaja
// väljakutseasukohta tagastada, ning peale returni on muutuja nimi tagastatava infoga. Peale return lauset, ei.
//teostata mitte ühtegi muud meetodi sisu. Return toimib ka kui breakina, lõpetades siis aktiivse meetodi töö.

//    public static void UusMeetod()
//        {
//            Console.WriteLine("Tere");

//        }                              //Meetodi signatuur, mis omab juurdepääsumodifikaatorit "public", "static" ütleb, et
//                                       // ta on selle klassi oma, tagastustüüp "void" ütleb et adnmeid mete meetod ei tagasta.
//                                       // ning pärast meetodi omadusi on meetodi nimi "Uusmeetod" peale mida on sulud, kus
//                                       //parameetreid ei ole
//                                       //pärast signatuuri on koodiplokk meetodi koodiga {}
//                                       //antud juhul kuvab konsooli sõnumi
//                                       //2. tüüpi meetod - tagastab väärtuse
//int[] arvutatavadarvud = new int[] { 3, 67, 420 }; //Töödeldavad andmeid, mis asuvad täisarvumasiivis, muutujanimega
//                                                   //"arvutavadarvud.

//public static int ArvutaKokku(int[] arvud) //Meetod, mille signatuuriks on juurdepääsuifikaator public static, static
//                                           //ütleb et meetod kuulub siia klassi, tagastustüüp "int" ütleb, et
//                                           //programis väljakutseasukohta tagastatakse täisarv, peale seda on
//                                           //meetodi nimi "ArvutaKokku" ning sulgude vahel ootab meetod täisarvumasiivi
//                                           // millele pannakse meetodi sees ajutine nimi arvud. Peale signatuuri on
//                                           //koodiplokk {} tehtava koodiga.
//{
//    int summa = 0; //tekitatakse täisarvuandmetüüpi muutuja nimega "summa", kuhu esialgu omistatakse arv 0.

//    foreach (int i in arvud) // foreach tsükliga kõik täisarvumassiivi "arvud" arvud läbi.
//    {
//        summa +=i; //ja muutujale summa lisatakse juurde, hetkel käidav element.
//    }
//    return summa;  //pärast tsükli töö lõppu tagastakse "return" käsu abil, muutuja summa sisu.
//}
//}