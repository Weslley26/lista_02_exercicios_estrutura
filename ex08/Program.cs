/*Um atendente de suporte técnico deseja contar quantas chamadas atendeu em 
um dia. O aluno deverá pedir ao usuário que insira o tempo de duração de cada 
chamada em minutos até que ele digite 0. O programa deve calcular o total de 
minutos atendidos, utilizando while, do while e for.
*/

int totalChamadas = 0;
int duracao;
Console.WriteLine("Digite a duração das chamadas (0 para sair): ");
while (true)
{
    duracao = Convert.ToInt32(Console.ReadLine());
    if (duracao == 0) break;
    totalChamadas += duracao;
}
Console.WriteLine($"Total de chamadas atendidas: {totalChamadas} minutos");

//
totalChamadas = 0;
do
{
    Console.WriteLine("Digite a duração das chamadas (0 para sair): ");
    duracao = Convert.ToInt32(Console.ReadLine());
    if (duracao != 0) totalChamadas += duracao;
} while (duracao != 0);
Console.WriteLine($"Total de chamadas atendidas: {totalChamadas} minutos");

//
totalChamadas = 0;
for (;;)

{
    Console.WriteLine("Digite a duração das chamadas (0 para sair): ");
    duracao = Convert.ToInt32(Console.ReadLine());
    if (duracao == 0) break;
    totalChamadas += duracao;
}
Console.WriteLine($"Total de chamadas atendidas: {totalChamadas} minutos");