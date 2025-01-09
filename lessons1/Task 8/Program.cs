int[] tex;
int n = Convert.ToInt32(Console.ReadLine());
tex = new int[n];
for (int i = 0; i<n; i++) {
    tex[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i<n; i++) {
    if (tex[i]%2!=0) {
        System.Console.WriteLine(i);
    }
}