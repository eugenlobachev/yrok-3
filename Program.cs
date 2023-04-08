//Задача 19

/*int num,r,sum=0,t;
Console.Write(" Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if(num>9999 && num<100000)
{
for(t=num;num!=0;num=num/10)
{
r=num % 10;
sum=sum*10+r;
}
if(t==sum)
Console.Write($"{t} является палиндромом.");
else
Console.Write($"{t} не является палиндромом.");
} else
Console.Write("Не пятизачное, повторите попытку снова. ");*/



//Задача 21

Console.WriteLine("Введите х1");
double numXa = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y1");
double numYa = double.Parse(Console.ReadLine());
Console.WriteLine("Введите z1");
double numZa = double.Parse(Console.ReadLine());

Console.WriteLine("Введите х2");
double numXb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y2");
double numYb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите z2");
double numZb = double.Parse(Console.ReadLine());

double rust = Math.Sqrt(Math.Pow((numXb-numXa), 2) + Math.Pow((numYb - numYa), 2) + Math.Pow((numZb - numZa), 2) );
Console.WriteLine($"{rust}");
