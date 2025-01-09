int[] a;
int num = Convert.ToInt32(Console.ReadLine());
a = new int[num];
for (int i=0; i<num; i++) {
    a[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i=0; i<num; i++) {
    if (a[i]%2!=0) {
        System.Console.WriteLine(a[i] + " ");
    }
}