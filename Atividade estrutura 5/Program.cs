Console.WriteLine($"Digite o número de maçãs compradas: ");
float totaldemaçãs = float.Parse (Console.ReadLine()!);

if (totaldemaçãs >= 12) 

 { 
  float  preço = totaldemaçãs * (float)0.25;
  Console.WriteLine($"O valor total das maçãs é: {preço}");
  
     }


if (totaldemaçãs <= 6)

{
    float preço = totaldemaçãs * (float)0.30;
    Console.WriteLine($"o Valor das maçãs é igual a {preço}");
    
}

  

  

