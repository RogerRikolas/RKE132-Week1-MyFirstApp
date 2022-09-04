
// rakendus küsib kasutjal sisestada nime
// tuleb tervitus

Console.WriteLine("Mis on sinu nimi?");
string userName = Console.ReadLine(); //input
Console.WriteLine("Tere " + userName + "!");
// string interpolation
Console.WriteLine($"Hello, {userName} !"); //output
