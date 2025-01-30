/*
 
 Um cliente deseja saber o total de suas compras em um supermercado. O aluno 
deve solicitar que o usuário insira o valor de cada compra até que ele digite 0. A 
soma dos valores das compras deve ser implementada usando as três estruturas 
de repetição.
 
 */

double totalCompras = 0;
double valorcompra;
Console.WriteLine("Digite o valor das compras (0 para sair): ");
while (true)
{
    valorcompra = Convert.ToDouble(Console.ReadLine());
    if (valorcompra == 0) break;
    totalCompras += valorcompra;
}
Console.WriteLine($"Total de compras: {totalCompras}");

//
totalCompras = 0;
do
{
    Console.WriteLine("Digite o valor das compras (0 para sair): ");
    valorcompra = Convert.ToDouble(Console.ReadLine());
    if (valorcompra != 0) totalCompras += valorcompra;
} while (valorcompra != 0);
Console.WriteLine($"Total de compras: {totalCompras}");

//
totalCompras = 0;
for (;;)
{
    Console.WriteLine("Digite o valor das compras (0 para sair): ");
    valorcompra = Convert.ToDouble(Console.ReadLine());
    if (valorcompra == 0) break;
    totalCompras += valorcompra;
}
Console.WriteLine($"Total de compras: {totalCompras}");