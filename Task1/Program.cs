
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Minimum: {FindMinimum(a, b, c, d)}");


int FindMinimum(int a, int b, int c, int d)
{
    if (a < b && a < c && a < d)
    {
        return a;
    }
    else if (b < a && b < c && b < d)
    {
        return b;
    }
    else if (c < a && c < b && c < d)
    {
        return c;
    }
    else
    {
        return d;
    }
}