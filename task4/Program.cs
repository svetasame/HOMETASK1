Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [] {a, b, c};
int i = 0;
int max = numbers [i];
while(i < numbers.Length)
{
  if (numbers[i] > max)
  {
    max = numbers[i];
    i++;
  }
  else
  {
    i++;
  }
}
Console.Write("Максимальное число из трех: ");
Console.Write(max);