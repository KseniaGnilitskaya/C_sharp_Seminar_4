/* напишите программу, которая на вход принимает число N и выдает сумму чисел от 1 до N */

Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine());
int i = 1;
int sum = 0;

while (i <= number) {
    sum += i;
    i ++;
}
Console.Write($"Sum from 1 to number is {sum}");

/* Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= number; i++) {
    sum += i;
}
Console.Write($"Sum from 1 to number is {sum}");*/