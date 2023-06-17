int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
int min = arr[0], max = arr[0], a = 0, b = 0;;
for (int i = 0; i < n; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
        a = i;
    } 
    if (arr[i] > max)
    {
        max = arr[i];
        b = i;
    } 
}
for (int i = a; i <= b; i++)
{
    System.Console.Write(arr[i] + " ");
}