using System;
class Program
{
    static void Main()
    {
        int altura = 10; // altura da árvore
        // Desenha a parte triangular da árvore
        for (int i = 1; i <= altura; i++)
        {
            // Espaços à esquerda
            Console.Write(new string(' ', altura - i));
            // Asteriscos da árvore
            Console.WriteLine(new string('*', 2 * i - 1));
        }
        // Desenha o tronco da árvore
        for (int i = 0; i < altura / 3; i++)
        {
            Console.Write(new string(' ', altura - 1));
            Console.WriteLine("|");
        }
    }
}