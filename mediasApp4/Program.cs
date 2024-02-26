string? nome = "";
double[] notas = new double[4];
double soma = 0;
int qtdeAlunos = 0;
double media;

string? i;

Console.Write("Nome: ");
nome = Console.ReadLine();
while (nome != "0")
{
    media = 0;

    for (int j = 0; j < 4; j++)
    {
        Console.Write("Nota do " + (j + 1) + "º bimestre: ");
        i = Console.ReadLine();
        bool conv = Double.TryParse(i, out notas[j]);
        if (notas[j] >= 0 && notas[j] <= 10 && conv)
        {
            media += notas[j];
        }
        else
        {
            Console.WriteLine("Nota inválida!")
            j--;
        }

    }
    media /= 4;

    Console.WriteLine("Nome do aluno: " + nome);
    Console.WriteLine("Media final: " +
        String.Format("{0:.#}", media));
    if (media >= 6)
    {
        Console.WriteLine("Aprovado!");
    }
    else
    {
        Console.WriteLine("Reprovado!");
    }

    soma += media; // calculo da media final
    qtdeAlunos++; // calculo da media final

    Console.Write("Nome: ");
    nome = Console.ReadLine();
}
Console.WriteLine("Média geral da turma: " +
    String.Format("{0:.#}", soma / qtdeAlunos));