Console.Write("Choose medium (Air,Steel,Water):");
String medium = Console.ReadLine();
Console.Write("Enter Distance:");
double distance = Convert.ToDouble(Console.ReadLine());

if(medium.Equals("Air")) {Console.WriteLine("Time = " +(distance/1100 ));}

else if(medium.Equals("Water")) {Console.WriteLine("Time = " +(distance/4900 ));}

else if(medium.Equals("Steel")) {Console.WriteLine("Time = " +(distance/16400));}


