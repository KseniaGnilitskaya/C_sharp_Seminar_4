/* напишите программу, которая принимает на вход число и выдает количество цифр в числе*/

Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (number != 0) {  // пока число не равно 0, тогда можем делить его на 10
    number = number / 10; // деление на 10  это первая цифра
    count ++;
}

Console.Write($"Total amount of digits in number is {count}");

