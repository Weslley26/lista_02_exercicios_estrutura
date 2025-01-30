/*
 Uma escola deseja saber quantos alunos foram aprovados em uma disciplina. O 
aluno deverá solicitar que o usuário insira as notas dos alunos (de 0 a 10) e, ao 
digitar -1, encerrará a entrada. Em seguida, deve contar quantos alunos tiveram 
nota maior ou igual a 6, utilizando as três estruturas de repetição. 
 */

int allunosAprovados = 0;
double nota;
Console.WriteLine("Digite as notas dos alunos (de 0 a 10) e -1 para sair: ");
while (true)
{
    nota = Convert.ToDouble(Console.ReadLine());
    if (nota == -1) break;
    if (nota >= 6) allunosAprovados++;
}
Console.WriteLine($"Total de alunos aprovados: {allunosAprovados}");

//
allunosAprovados = 0;
do
{
    Console.WriteLine("Digite as notas dos alunos (de 0 a 10) e -1 para sair: ");
    nota = Convert.ToDouble(Console.ReadLine());
    if (nota >= 6 && nota != -1) allunosAprovados++;
} while (nota != -1);
Console.WriteLine($"Total de alunos aprovados: {allunosAprovados}");

//
allunosAprovados = 0;
for (;;)
{
    Console.WriteLine("Digite as notas dos alunos (de 0 a 10) e -1 para sair: ");
    nota = Convert.ToDouble(Console.ReadLine());
    if (nota == -1) break;
    if (nota >= 6) allunosAprovados++;
}
Console.WriteLine($"Total de alunos aprovados: {allunosAprovados}");    