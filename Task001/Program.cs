//напишите программу которая на ивходе принимает число и возводит его в квадрат
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number ;
Console.WriteLine(square);
Console.WriteLine($"Квадрат числа {number} = {square}");
