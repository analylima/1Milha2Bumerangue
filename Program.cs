double percentualDeBonus, percentualDeRetorno;
double pontosATransferir, pontosAReduzir, pontosAAcrescentar;
 
Console.Clear();
Console.WriteLine("--- Milhas Bumerangue ---\n");
 
Console.WriteLine("Percentual De Bonus....: ");
percentualDeBonus = Convert.ToDouble(Console.ReadLine());
 
Console.WriteLine("Percentual de Retorno...: ");
percentualDeRetorno = Convert.ToDouble(Console.ReadLine());
 
Console.WriteLine("Pontos a Transferir.....: ");
pontosATransferir = Convert.ToDouble(Console.ReadLine());
 
pontosAReduzir = pontosATransferir - (pontosATransferir * percentualDeBonus) / 100;
pontosAAcrescentar = pontosATransferir + (percentualDeBonus * percentualDeBonus) / 100;
 
Console.WriteLine();
Console.WriteLine($"Pontos a reduzir na origem........: {pontosAReduzir}");
Console.WriteLine($"Pontos a reduzir no destino...: {pontosAAcrescentar}");