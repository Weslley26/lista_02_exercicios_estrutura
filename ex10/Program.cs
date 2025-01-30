/*
Um vendedor de passagens deseja saber quantas passagens ele vendeu em um 
dia. O aluno deve pedir ao usuário para inserir o valor das passagens vendidas até 
que ele digite um valor negativo. O total de passagens vendidas deve ser calculado 
e apresentado utilizando while, do while e for.
 
 */

int totalPassagens = 0;
double valorPassagem;
Console.WriteLine("Digite o valor das passagens (0 para sair): ");
while (true)
{
    valorPassagem = Convert.ToDouble(Console.ReadLine());
    if (valorPassagem == 0) break;
    totalPassagens++;
}
Console.WriteLine($"Total de passagens vendidas: {totalPassagens}");

//
totalPassagens = 0;
do
{
    Console.WriteLine("Digite o valor das passagens (valor negativo para sair):");
    valorPassagem = Convert.ToDouble(Console.ReadLine());
    if (valorPassagem >= 0) totalPassagens++;
} while (valorPassagem >= 0);
Console.WriteLine($"Total de passagens vendidas: {totalPassagens}");

//
totalPassagens = 0;
for (; ; )
{
    Console.WriteLine("Digite o valor das passagens vendidas(valor negativo para sair):");
    valorPassagem = Convert.ToDouble(Console.ReadLine());
    if (valorPassagem == 0) break;
    totalPassagens++;
}

Console.WriteLine($"Total de passagens vendidas: {totalPassagens}");
