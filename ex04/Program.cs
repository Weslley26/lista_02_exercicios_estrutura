/*

m grupo de amigos deseja calcular a idade média deles. Para isso, o aluno deve 
pedir que o usuário insira as idades e calcule a média até que o usuário digite 0. A 
solução deve ser implementada usando while, do while e for. 

*/
double somaIdades = 0;
int idade;
int contador = 0;
Console.WriteLine("Digite as idades dos amigos (0 para sair): ");
while (true)
{
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade == 0) break;
    somaIdades += idade;
    contador++;
}
double mediaIdade = contador > 0 ? somaIdades / contador : 0;
Console.WriteLine($"Média de idades: {mediaIdade}");

//
somaIdades = 0;
contador = 0;
do
{
    Console.WriteLine("Digite as idades dos amigos (0 para sair): ");
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade != 0)
    {
        somaIdades += idade;
        contador++;
    }
} while (idade != 0);
mediaIdade = contador > 0 ? somaIdades / contador : 0;
Console.WriteLine($"Média de idades: {mediaIdade}");

//
somaIdades = 0;
contador = 0;
for (;;)
{
    Console.WriteLine("Digite as idades dos amigos (0 para sair): ");
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade == 0) break;
    somaIdades += idade;
    contador++;
}
mediaIdade = contador > 0 ? somaIdades / contador : 0;
Console.WriteLine($"Média de idades: {mediaIdade}");
