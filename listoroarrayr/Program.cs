using System.Reflection.Metadata;
Random  rnd = new Random ();

string[] leksaker = ["nalle", "docka", "träsvärd", "boll", "bil"];
string[] personer = ["alexander", "nilo","dante","jack","lukas"];
int[] nummer = [0,1,2,3,4,5,6,7,8,9,10];
List<string> cities = [];
for (int t = 0; t < 5; t++)
{
    int betyg = rnd.Next(0,10);
Console.WriteLine($"{personer[t]} ger {leksaker[t]} {nummer[betyg]} i betyg");
}
string exit="";
Console.WriteLine("säg en stad eller något liknande skriv exit för att stänga ner");
while ( exit != "exit")
{  
    exit = Console.ReadLine();
    if (exit != "exit") cities.Add(exit);   
}
for(int repeat = 0; repeat<cities.Count; repeat++)
{
Console.WriteLine(cities[repeat]);
}
Console.ReadLine();