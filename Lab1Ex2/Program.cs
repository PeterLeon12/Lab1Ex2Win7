//Ex2
//Scrieti un program care va calcula media aritmetica a trei numere citite de la
//tastatura


Console.WriteLine("Introduceti primul numar");
int nr1 = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti al doilea numar");
int nr2 = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti al treilea numar");
int n3 = int.Parse(Console.ReadLine());

int mediatAritmeticaTreiNumere = (nr1 + nr2 + n3) / 3;

Console.WriteLine("Media aritmetica a celor 3 numere este" + " " + mediatAritmeticaTreiNumere);