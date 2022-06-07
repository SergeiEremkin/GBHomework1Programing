int a = 25;
int b = 28;
int c = 28;
int max = a;
if(max < b)
{
    max = b;
     
}
if(max < c)
{
    max = c;
    
}
else if (max == b || max == c || b == c)
{
System.Console.Write($"Числа равны между собой.");
}
Console.Write($" Максимальное значение - {max}");