﻿/*
 9. Dia da Semana (usando if-else)
o Objetivo: Praticar a utilização de múltiplas condições com if, else if e else.
o Descrição: Desenvolva um programa que peça um número de 1 a 7 e exiba
o dia da semana correspondente (1 para "Domingo", 2 para "Segunda-feira",
etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de
erro.
o Exemplo de Saída: "Domingo", "Segunda-feira", etc., ou "Número inválido.
Digite um número de 1 a 7."
 */
Console.WriteLine("digite um numero  de 1 a 7 correspondente aos dias da semana ");
int numero = int.Parse(Console.ReadLine());
if (numero <1 && numero > 7) 
{
    Console.WriteLine("numero não valido");
}
else if (numero == 1)
{
    Console.WriteLine("segunda");
}
else if (numero == 2)
{
    Console.WriteLine("terça");
}
else if (numero == 3)
{
    Console.WriteLine("quarta");
}
else if (numero == 4)
{
    Console.WriteLine("quinta");
}
else if (numero == 5)
{
    Console.WriteLine("sexta");
}
else if (numero == 6)
{
    Console.WriteLine("sabado");
}
else if (numero == 7)
{
    Console.WriteLine("domingo");
}
