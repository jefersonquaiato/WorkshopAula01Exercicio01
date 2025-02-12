// See https://aka.ms/new-console-template for more information
Console.Write("Digite o valor inteiro de N1: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor inteiro de N2: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Soma(n1, n2);
Subtracao(n1, n2);
Multiplicacao(n1, n2);
Divisao(n1, n2);
Modulo(n1, n2);

void Soma(int n1, int n2)
{
    int soma = n1 + n2;
    Console.WriteLine($"\nSoma: {n1} + {n2} = {soma}");
}

void Subtracao(int n1, int n2)
{
    int subtracao = n1 - n2;
    Console.WriteLine($"Subtração: {n1} - {n2} = {subtracao}");
}

void Multiplicacao(int n1, int n2)
{
    int multiplicacao = n1 * n2;
    Console.WriteLine($"Multiplicação: {n1} x {n2} = {multiplicacao}");
}

void Divisao(int n1, int n2)
{
    int divisao = n1 / n2;
    Console.WriteLine($"Divisão: {n1} / {n2} = {divisao}");
}

void Modulo(int n1, int n2)
{
    int modulo = n1 % n2;
    Console.WriteLine($"Resto da divisão: {n1} % {n2} = {modulo}");
}