//напишите программу которая будет проверять является ли первое число квадратом второго
Console.WriteLine("Введите число 1: ");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
//Console.WriteLine($"Квадрат числа {number} = {square}");
int number1 = Convert.ToInt32(Console.ReadLine());


if (number1*number1==number)
{
    
    Console.WriteLine("да");
}

else

{
   Console.WriteLine("печаль"); 
}
