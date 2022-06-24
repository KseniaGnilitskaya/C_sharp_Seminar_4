/* напишите программу, которая принимает на вход число и выдает количество цифр в числе*/

Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (number != 0) {
    number = number / 10;
    count ++;
}
Console.Write($"Total amount of digits in number is {count}");

