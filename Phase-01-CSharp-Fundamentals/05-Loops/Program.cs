for(int i=1; i<=5; i++)
{
    Console.WriteLine(i);
} 

int j = 1;

while (j <= 5)
{
    Console.WriteLine(j);
    j++;
}

int k = 10;

do
{
    Console.WriteLine(k);
    k++;
}                                               

while (k <= 15);  


int[] numbers = { 10, 20, 30, 40, 50 };

foreach (int number in numbers)
{
    Console.WriteLine(number);
}  

for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        break;
    }

    Console.WriteLine(i);
}  

for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        continue;
    }

    Console.WriteLine(i);
}  

for (int i = 1; i <= 3; i++)
{
    for (int l = 1; l <= 5; l++)
    {
        Console.WriteLine($"{i} x {l} = {i * l}");
    }

    Console.WriteLine();
}