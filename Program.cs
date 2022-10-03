bool[] a =new bool[100];
for (int i = 1; i <= 100; i++)
{
    a[i-1] = false;
}
//for (int i = 1; i <= 100; i++)
//{
//    Console.WriteLine(i + " is " + a[i-1]);
//}
for (int i = 1; i <= 100; i++)
{
    for (int j = 1; j <= 100; j++)
    {
        if(((i * j) - 1)<=100)
        a[(i * j) - 1] = !a[(i * j) - 1];
    }

}

for (int k = 1; k <= 100; k++)
{
    Console.WriteLine(k + " is " + a[k - 1]);
}