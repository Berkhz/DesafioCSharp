int contadora = 0;
double resultado = 0;
double notas = 0;
int quantidadeNotas = 0;
double media = 0;
int verificacao = 0;
string professor = " ";

Console.WriteLine("Bem vindo ao Calculador de Média Final!");
Console.WriteLine("Qual o seu nome?");
professor = Console.ReadLine();

Console.WriteLine(professor + " vamos começar!");
do
{
contadora = 0;
resultado = 0;
notas = 0;
quantidadeNotas = 0;
media = 0;

Console.WriteLine("Me informe quantas notas você deseja calcular a média final: ");
quantidadeNotas = int.Parse(Console.ReadLine());

while(quantidadeNotas != 0)
{
    contadora = contadora + 1;
    Console.WriteLine("Me informe a " + contadora + "° nota: ");
    notas = double.Parse(Console.ReadLine());
    resultado = resultado + notas;
    quantidadeNotas = quantidadeNotas - 1;
}

media = resultado / contadora;
if (media >= 6)
{
    Console.WriteLine(
    @"A média do aluno foi de: " + media + 
    " Parábens você passou!");
}
else
{
    Console.WriteLine(
    @"A média do aluno foi de: " + media + 
    " Você está de recuperação!");
}

Console.WriteLine(
    @"Deseja continuar?
    Digite 1 para SIM ou 0 para não");
verificacao = int.Parse(Console.ReadLine());

}
while(verificacao != 0);