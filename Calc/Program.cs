using Calc.Services;

CalculadoraImpl c = new CalculadoraImpl();

int num1 = 2;
int num2 = 3;

Console.WriteLine(c.Somar(num1, num2));
Console.WriteLine(c.Subtrair(num1, num2));
Console.WriteLine(c.Multiplicar(num1, num2));
Console.WriteLine(c.Dividir(num1, num2));
Console.WriteLine(c.Exp(num1, num2));
Console.WriteLine(c.Modulus(num1, num2));
