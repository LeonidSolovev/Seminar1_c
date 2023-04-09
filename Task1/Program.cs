Console.Write("Введите целое число: ");
string inputA = Console.ReadLine() ?? "";
int numberA = int.Parse(inputA);

Console.Write($"Введите квадрат числа {numberA} : ");
string inputB = Console.ReadLine() ?? "";
int numberB = int.Parse(inputB);

int sqr = numberA*numberA;

if (numberB == sqr){
    Console.WriteLine("Верно!");
}
else{
    
    Console.WriteLine($"Нет! Квадрат числа {numberA} - {sqr}");
}
