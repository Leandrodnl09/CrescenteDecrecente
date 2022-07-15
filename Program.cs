// Testando exercício "Crescente ou decrescente"

string[] Num = Console.ReadLine().Split(' ');
int X = int.Parse(Num[0]);
int Y = int.Parse(Num[1]);

while (X != Y)
{
    if (X > Y)
    {
        Console.WriteLine("Decrescente");
    }
    else
    {
        Console.WriteLine("Crescente");
    }
Num = Console.ReadLine().Split(' ');
X = int.Parse(Num[0]);
Y = int.Parse(Num[1]);
}