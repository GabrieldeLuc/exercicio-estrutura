Console.WriteLine($"Bem vindo ao Sistema, informe o seu salario:  ");
float salario = float.Parse (Console.ReadLine()!);

Console.WriteLine($"Agora, favor informe o seu total de gastos: ");
float gastos = float.Parse (Console.ReadLine()!);

if (gastos < salario)

Console.WriteLine($"seus Gastos estão dentro do seu Orçamento.");
else 

Console.WriteLine($"seu Orçamento foi estourado !");




