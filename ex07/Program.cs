/*
 . Um ciclista deseja saber a distância total que percorreu. Para isso, o aluno deve 
solicitar que o usuário insira as distâncias percorridas em cada dia até que um valor 
negativo seja digitado. A soma das distâncias deve ser calculada e exibida 
utilizando as três estruturas de repetição.
 */

double distanciaTotal = 0;
double distancia;
Console.WriteLine("Digite as distâncias percorridas em cada dia (valor negativo para sair): ");
while (true)
{
    distancia = Convert.ToDouble(Console.ReadLine());
    if (distancia < 0) break;
    distanciaTotal += distancia;
}
Console.WriteLine($"Distância total percorrida: {distanciaTotal} km");

//
distanciaTotal = 0;
do
{
    Console.WriteLine("Digite as distâncias percorridas em cada dia (valor negativo para sair): ");
    distancia = Convert.ToDouble(Console.ReadLine());
    if (distancia >= 0) distanciaTotal += distancia;
} while (distancia >= 0);
Console.WriteLine($"Distância total percorrida: {distanciaTotal} km");

//
distanciaTotal = 0;
for (;;)
{
    Console.WriteLine("Digite as distâncias percorridas em cada dia (valor negativo para sair): ");
    distancia = Convert.ToDouble(Console.ReadLine());
    if (distancia < 0) break;
    distanciaTotal += distancia;
}
Console.WriteLine($"Distância total percorrida: {distanciaTotal} km");