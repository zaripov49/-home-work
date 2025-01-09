int[] arr;
int n = Convert.ToInt32(Console.ReadLine());
arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
// int sum=0;
for (int i =0; i<n; i++)
{
    if(arr[i]%2!=0)
    {
        Console.WriteLine(Math.Pow(arr[i],2));
    }
}
