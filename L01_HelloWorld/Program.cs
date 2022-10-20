// Tivoli OPA

Console.WriteLine($"Hej, välkommen till vårt tivoli.");

// Biljetternas pris - operationer och datatyper har vi använt oss av i denna delen.


var körmeny = true;
var menyval = 0;


while (körmeny)
{
    Console.WriteLine("\n Vad vill du göra nu? \n 1. Åka karusell \n 2. Handla mat \n 3. Gå hem ");
    menyval = int.Parse(Console.ReadLine());
    switch (menyval)
    {
        case 1: Karusell();
            break;
        
        case 2: Snacks();
            break;

        case 3: Console.WriteLine("Hej då!");
            körmeny = false;
            break;
    }
}

 static void Karusell(){
     var barnbiljett = 50;
     var vuxenbiljett = 100;
     var antalbarn = 0; //hur många biljetter man har för barn
     var antalvuxen = 0; //hur många biljetter man har för vuxen

    Console.WriteLine("Hur många barnbiljetter vill du ha?");
    antalbarn = int.Parse(Console.ReadLine());
    Console.WriteLine("Hur många vuxenbiljetter vill du ha?");
    antalvuxen = int.Parse(Console.ReadLine());
    Console.WriteLine($"Summan blir: {barnbiljett * antalbarn + antalvuxen * vuxenbiljett}");

// Karuseller
// Ange längd
// Biljettpris per åk

    var karusell1 = "flumeride";
    var karusell2 = "colorado";

// vi vill att namnet på karusellen ska vara i stora bokstäver

    var svar = ""; 

    do
    {
        Console.WriteLine($"Vill du åka {karusell1.ToUpper()} eller {karusell2.ToUpper()}? ");
        svar = Console.ReadLine().ToLower();
    } while (svar != karusell1 && svar != karusell2);

    Console.WriteLine($"Hur många barn ska åka?");
    var barnåk = int.Parse(Console.ReadLine());
    Console.WriteLine($"Hur många vuxna ska åka?");
    var vuxenåk = int.Parse(Console.ReadLine());

    if (svar == karusell1)
    {
        antalbarn = antalbarn - barnåk;
        antalvuxen = antalvuxen - vuxenåk;
        Console.WriteLine($"Du har {antalbarn} barnbiljetter och {antalvuxen} vuxenbiljetter kvar efter detta åket.");
    }
    else if (svar == karusell2) // denna ska kosta 2ggr mer än karusell1
    {
        antalbarn = antalbarn - barnåk * 2;
        antalvuxen = antalvuxen - vuxenåk * 2;
        Console.WriteLine($"Du har {antalbarn} barnbiljetter och {antalvuxen} vuxenbiljetter kvar efter detta åket.");
    }
    
}
 static void Snacks(){


    string[] snacks = new string[] { "popcorn", "chips", "sockervadd", "hallon", "betala" };
    int[] prissnacks = new int[] { 10, 15, 5, 30};

//string[] dricka = new string[] { "kaffe", "powerking", "pepsimax", "juice" };
// int[] prisdricka = new int[] { 15, 10, 20, 30 };

    Console.WriteLine($"Detta kan du köpa: ");
    int j = 1;
    for (int i = 0; i < snacks.Length; i++)
    {
        Console.WriteLine($"{j} {snacks[i]}");
        j++;
    }

    var snackval = 0;
    var summa = 0;
    var körsnacksmeny = true;

    while (körsnacksmeny)
    {
        snackval = int.Parse(Console.ReadLine());
        switch (snackval)
        {
            case 1:
                summa = summa + prissnacks[0];
                break;
            case 2: 
                summa = summa + prissnacks[1];
                break;
            case 3: 
                summa = summa + prissnacks[2];
                break;
            case 4:
                summa = summa + prissnacks[3];
                break;
            case 5: 
                Console.WriteLine($"Summan blir: {summa} dollar");
            
                körsnacksmeny = false;
                break;
        
            default: Console.WriteLine($"Du valde inget i menyn.");
                break;
            
        }
    }
}
