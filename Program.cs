Console.Write("Введите первое число ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int secondnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int thirdnumber = Convert.ToInt32(Console.ReadLine());
if (firstnumber > secondnumber && firstnumber > thirdnumber)
{
Console.Write("max = " + firstnumber);
}
else if (secondnumber > firstnumber && secondnumber > thirdnumber)
{
Console.Write("max = " + secondnumber);
}
else if (thirdnumber > secondnumber && thirdnumber > firstnumber)
{
Console.Write("max = " + thirdnumber);
}
else
{Console.Write("Числа равны");}