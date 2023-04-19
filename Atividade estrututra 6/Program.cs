

Console.WriteLine($"Bem vindo ao Sistema, informe a quantidade de aulas que o aluno compareceu:  ");
float frequencia = float.Parse(Console.ReadLine()!);


frequencia = (frequencia / 200) * 100;

if (frequencia < 75)
{
    Console.WriteLine($"o aluno não pode ser aprovado, frequência abaixa da média");
}
else
{
    Console.WriteLine($"informe as notas do aluno, começando pela primeira: ");
    float nota1 = float.Parse(Console.ReadLine()!);

    Console.WriteLine($"informe a segunda nota:  ");
    float nota2 = float.Parse(Console.ReadLine()!);

    Console.WriteLine($"informe a terceira nota:  ");
    float nota3 = float.Parse(Console.ReadLine()!);

    Console.WriteLine($"informe a quarta nota: ");
    float nota4 = float.Parse(Console.ReadLine()!);

    float media = (nota1 + nota2 + nota3 + nota4) / 4;

    if(media < 3)
    {
        Console.WriteLine($"Aluno reprovado");

    } else if(media >= 7) 
    {
        Console.WriteLine($"Aluno Aprovado ");
    }

   else 
   {
     Console.WriteLine($"Aluno de Recuperação");
   }

       
}
