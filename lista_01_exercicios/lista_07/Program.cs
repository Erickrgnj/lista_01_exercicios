/*
 7. Comparação de Números
o Objetivo: Praticar a comparação entre variáveis.
o Descrição: Escreva um programa que solicita dois números ao usuário e
determina qual deles é maior. Utilize if, else if e else para exibir a mensagem
adequada.
o Exemplo de Saída: "O primeiro número é maior.", "O segundo número é
maior." ou "Os números são iguais
 */
Console.WriteLine(" primeiro numero");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine(" segundo numero ");
int numero2 = int.Parse(Console.ReadLine());
if (numero > numero2 )
{
    Console.WriteLine("primeiro numero é maior que o segundo");
}
else if (numero2 > numero)
{
    Console.WriteLine("segundo numero é maior que o primeiro ");
}
else if(numero2 == numero)
{
    Console.WriteLine(" são iguais ");
}