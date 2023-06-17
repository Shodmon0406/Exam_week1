int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
int b;
for (int i = 1; i < n; i+=2)
{
    b = arr[i - 1];
    arr[i - 1] = arr[i];
    arr[i] = b; 
}
foreach (var item in arr)
{
    System.Console.Write(item + " ");
}