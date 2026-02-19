using ControleGastosOO;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        // Meu controle que pode ter vários gastos
        ControleDeGastos despesas = new ControleDeGastos();
       
        // Gasto
        Gasto mercado = new Gasto("Mercado", 100, 9, 2025);

        despesas.AdicionarGasto(mercado);
        despesas.AdicionarGasto(new Gasto("farmacia", 200, 7, 2025));
        despesas.AdicionarGasto(new Gasto("padaria", 90, 9, 2025));
        despesas.AdicionarGasto(new Gasto("conta de luz", 80, 8, 2025));
        
        int opcao = 0;
        do
        {
            exibirMenu();
            opcao = Convert.ToInt16(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    despesas.AdicionarGasto(entradaDados());
                    break;
                case 2:
                    despesas.ListarGastos();
                    break;
                case 3:
                    Console.WriteLine("Total de Gastos: R$ {0}", despesas.CalcularTotal());
                    break;
                case 4:
                    int mes=0, ano=0;
                    entradaDadosMesAno(ref mes, ref ano);
                    despesas.ListarPorMesAno(mes, ano);
                    break;
            }

        } while (opcao != 0);
    }

    public static void entradaDadosMesAno(ref int mes, ref int ano)
    {
        Console.WriteLine("Mês: ");
        mes = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Ano: ");
        ano = Convert.ToInt16(Console.ReadLine());
    }

    public static Gasto entradaDados()
    {
        string descricao;
        decimal valor;
        int mes, ano;
        Console.WriteLine("Descrição: ");
        descricao = Console.ReadLine();

        Console.WriteLine("Valor: ");
        valor = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Mês: ");
        mes = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Ano: ");
        ano = Convert.ToInt16(Console.ReadLine());

        Gasto gasto = new Gasto(descricao,valor, mes, ano);
        return gasto;
    }
    public static void exibirMenu()
    {
        Console.WriteLine("\n   Controle de Gastos");
        Console.WriteLine("=========================");
        Console.WriteLine("1 - Adicionar gasto");
        Console.WriteLine("2 - Listar gastos");
        Console.WriteLine("3 - Calcular total gasto");
        Console.WriteLine("4 - Listar gastos mês/ano");
        Console.WriteLine("0 - Sair\n");
        Console.Write("Opção: ");
    }

}