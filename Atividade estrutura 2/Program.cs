Console.WriteLine($"Bem vindo ao Sistema, informe quantos gols fez o primeiro Time: ");
float primeirotime = float.Parse (Console.ReadLine()!);

Console.WriteLine($"Agora, informe quantos gols fez o segundo Time: ");
float segundotime = float.Parse (Console.ReadLine()!);

if (primeirotime > segundotime)

Console.WriteLine($"Vitória do Primeiro Time !");

else if (primeirotime < segundotime)

Console.WriteLine($"Vitória do Segundo Time !");

else if (primeirotime == segundotime)

Console.WriteLine($"Empate entre os Times !");






