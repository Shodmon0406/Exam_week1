int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
int cnt = 1;
Array.Sort(arr);
for (int i = 0; i < n - 1; i++)
{
    if (arr[i] != arr[i + 1])
    {
        cnt++;
    }
}
System.Console.WriteLine(cnt);