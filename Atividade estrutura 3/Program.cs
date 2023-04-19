Console.WriteLine($"Bem vindo ao Sistema, Informe a primeira medida do triangulo: ");
float medida1 = float.Parse (Console.ReadLine()!);

Console.WriteLine($"Agora, Informe a segunda medida do triangulo: ");
float medida2 = float.Parse (Console.ReadLine()!);

Console.WriteLine($"Agora, Informe a terceira medida do triangulo: ");
float medida3 = float.Parse (Console.ReadLine()!);

if (medida1 == medida2 && medida1 == medida3 && medida2 == medida3)
Console.WriteLine($"Seu triangulo é equilátero !");

else if (medida1 == medida2 && medida1 != medida3 && medida2 != medida3  || medida2 == medida3 && medida2 != medida1 && medida3 != medida1
|| medida3 == medida1 && medida3 != medida2 && medida1 != medida2 ) 

Console.WriteLine($"seu triangulo é isóceles!");

else 

Console.WriteLine($"seu Triangulo é Escaleno !");














