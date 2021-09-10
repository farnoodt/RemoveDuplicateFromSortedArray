// See https://aka.ms/new-console-template for more information

int[] a = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 4, 4 };
int R, L = 1;
for(R =1; R<a.Length; R++)
{
    if(a[R] != a[R-1])
    {
        a[L] = a[R];
        L++;
    }
}


Console.WriteLine(L);
