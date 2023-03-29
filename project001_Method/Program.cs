//Программа выдаёт максимум из 9 чисел

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a = new Random().Next(1,10000);
int b = new Random().Next(1,10000);
int c = new Random().Next(1,10000);
int d = new Random().Next(1,10000);
int e = new Random().Next(1,10000);
int f = new Random().Next(1,10000);
int g = new Random().Next(1,10000);
int h = new Random().Next(1,10000);
int i = new Random().Next(1,10000);

// int max1 = Max(a, b, c);
// int max2 = Max(d, e, f);
// int max3 = Max(g, h, i);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(a, b, c),
    Max(d, e, f),
    Max(g, h, i));

Console.WriteLine(max);