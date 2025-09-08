using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do estudante:");

        // Erro corrigido: a variável 'nome' deve ser do tipo string, não int.
        string nome = Console.ReadLine();

        double soma = 0;

        // Erro corrigido: o loop deve iterar 3 vezes para ler 3 notas.
        // No código dado, o loop ia de 0 até 3 (4 vezes).
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Digite a nota " + i + ":");
            string entrada = Console.ReadLine();

            // Erro corrigido: converter a entrada de string para double antes de somar.
            // No código dado, tentava somar string com double, o que gera erro.
            if (double.TryParse(entrada, out double nota))
            {
                soma += nota;
            }
            else
            {
                // Tratamento de erro para entrada inválida.
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
                i--; // Repete a leitura da nota atual para garantir 3 notas válidas.
            }
        }

        // Erro corrigido: dividir a soma por 3 (quantidade de notas), não por 2.
        double media = soma / 3;

        // Erro corrigido: exibir o nome corretamente (era uma variável int no código dado).
        // Também formatar a média para mostrar 2 casas decimais.
        Console.WriteLine("A média do estudante " + nome + " é " + media.ToString("F2"));
    }
}
