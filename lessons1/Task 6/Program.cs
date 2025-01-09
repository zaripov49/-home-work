int c = 0;
int[] num = {2, 3, 1, 5, 4}
for (int i=0; i<num.Length; i++)
{
    if (i>i-1 && i>i+1) {
        c++;
    }
}
System.Console.WriteLine(c);