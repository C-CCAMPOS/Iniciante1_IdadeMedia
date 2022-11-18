int idade = 0;
int contador = 0;
int media = 0;

Console.WriteLine("***Projeto 1 - GitHub***\n\n\n");
Console.WriteLine("CALCULO DA IDADE MÉDIA DOS ALUNOS");

Console.Write("\n\nDigite a quantidade de alunos que deseja calcular a média: ");
contador = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i <= contador; i++)
{
    
    Console.Write("\n\nDigite a idade do aluno-" + i + ": ");
    idade += Convert.ToInt32(Console.ReadLine());
}

media = idade / contador;
Console.WriteLine("\n\nA média de idade entre " + contador + " alunos é de " + media + " anos.");



Console.ReadKey();
