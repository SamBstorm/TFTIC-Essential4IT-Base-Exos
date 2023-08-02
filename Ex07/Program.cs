int a, b, i;
a = 0;
b = 1;

for (i = 2;i<25; i++)
{
    int result = a + b;
    a = b;
    b = result;
    Console.WriteLine($"fibo numero {i+1} = {b}");
}

Console.WriteLine(b);