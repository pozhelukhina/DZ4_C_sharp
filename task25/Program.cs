// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Math.Pow юзать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Pow (int numA, int numB)
{
  int result = 1;
  for(int i=1; i <= numB; i++)
  {
    result = result * numA;
  }
        return result;
}
Console.Clear();
System.Console.WriteLine("Введите целое число A");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое число B");
int numB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Число A в степени B равнo {Pow (numA,numB)}");


