/* Напишите программу, которая принимает на вхoд число N и выдает произведение чисел от 1 до N */

/* Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int product = 1;

for (int i = 1; i <= number; i++) {
    product = product * i;
}
Console.Write($"The factorial of number is {product}");



Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int product = 1;
int i = 1;

while (i <= number) {
    product = product * i;
    i ++;
}
Console.Write($"The factorial of number is {product}");*/


Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

int fact(number) {
    int result = 1;

    for (int i = 1; i <= number; i++){
        result *= 1;
    }
    return result;
}
Console.Write($"The factorial of number is {fact{number}}");
