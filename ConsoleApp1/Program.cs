
Console.WriteLine("Escolha a operação desejada:");
Console.WriteLine("1 Adição");
Console.WriteLine("2 Subtração");
Console.WriteLine("3 Multiplicação");
Console.WriteLine("4 Divisão \n");

int operation = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o primeiro número:");

int myNum1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");

int myNum2 = int.Parse(Console.ReadLine());

int result = 0;

if (operation == 1)
{
    result = myNum1 + myNum2;
}
else if (operation == 2)
{
    result = myNum1 - myNum2;
}
else if (operation == 3)
{
    result = myNum1 * myNum2;
}
else if (operation == 4)
{
    result = myNum1 / myNum2;
}
else
{
    Console.WriteLine("Operação inválida, tente novamente.");
}

Console.WriteLine("O resultado é:{0}", myNum1 = result);
