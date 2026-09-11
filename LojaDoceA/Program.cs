
using LojaDoceA;

Console.WriteLine("=== SISTEMA DE PRODUÇÃO DE DOCES ===");
Console.WriteLine();

// 1. Instanciando o objeto da classe
Doce pedido = new Doce();

// 2. Leitura dos dados e atribuição ao objeto
Console.Write("Digite o nome do confeiteiro: ");
pedido.Confeiteiro = Console.ReadLine();

Console.Write("Capacidade total da encomenda (kg): ");
pedido.CapacidadeKg = Convert.ToDouble(Console.ReadLine());

Console.Write("Porcentagem da encomenda já pronta (%): ");
pedido.PorcentagemPronta = double.Parse(Console.ReadLine());

Console.Write("Taxa de produção por hora (kg/h): ");
pedido.TaxaProducaoPorHora = double.Parse(Console.ReadLine());

// 3. Exibição utilizando os métodos do objeto instanciado
Console.WriteLine("\n--- RELATÓRIO DE PRODUÇÃO ---");
Console.WriteLine($"Confeiteiro: {pedido.Confeiteiro?.Trim().ToUpper()}");
Console.WriteLine($"Qtd. Faltante: {pedido.CalcularkgFaltantes():F1} kg");
Console.WriteLine($"Tempo Estimado: {pedido.CalcularTempoRestanteHoras():F2} hora(s)");
Console.WriteLine($"Valor dos Doces Faltantes: R$ {pedido.CalcularValorFaltante():N2}");
