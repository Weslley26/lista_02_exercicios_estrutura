/* Um gerente de loja quer saber quantos produtos estão em estoque. O aluno deve 
solicitar que o usuário insira a quantidade de produtos recebidos e vendidos até 
que ele digite 0. Depois disso, o programa deve calcular a quantidade total de 
produtos em estoque, utilizando as três estruturas de repetição.
*/

int totalEstoque = 0;
int recebidos, vendidos;
Console.WriteLine("Digite a quantidade de produtos recebidos e vendidos (0 para sair): ");
while (true)
{
    Console.Write("Recebidos: ");
    recebidos = Convert.ToInt32(Console.ReadLine());
    if (recebidos == 0) break;
    Console.WriteLine("vendidos: ");
    vendidos = Convert.ToInt32(Console.ReadLine());
    totalEstoque += recebidos - vendidos;
}
Console.WriteLine($"Total de produtos em estoque: {totalEstoque}");

//
totalEstoque = 0;
do
{
    Console.Write("Digite a quantidade de produtos recebidos e vendidos (0 para sair): ");
    Console.Write("Recebidos: ");
    recebidos = Convert.ToInt32(Console.ReadLine());
    if (recebidos == 0) break;
    Console.Write("vendidos: ");
    vendidos = Convert.ToInt32(Console.ReadLine());
    totalEstoque += recebidos - vendidos;
} while (true);
Console.WriteLine($"Total de produtos em estoque: {totalEstoque}");

//
totalEstoque = 0;
for (;;)
{
    Console.Write("Digite a quantidade de produtos recebidos e vendidos (0 para sair): ");
    Console.Write("Recebidos: ");
    recebidos = Convert.ToInt32(Console.ReadLine());
    if (recebidos == 0) break;
    Console.Write("vendidos: ");
    vendidos = Convert.ToInt32(Console.ReadLine());
    totalEstoque += recebidos - vendidos;
}
Console.WriteLine($"Total de produtos em estoque: {totalEstoque}");