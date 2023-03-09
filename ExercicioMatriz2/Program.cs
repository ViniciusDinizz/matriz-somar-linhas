internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matint = new int[5, 5];

        matint = InserirNúmeros(matint);

        SomarLinhas(matint);

        SomarColunas(matint);

        SomarDiagonaldireita(matint);
        SomarDiagonalesquerda(matint);

        void SomarLinhas(int[,] matint)
        {
            int somatotal = 0;
            for (int linhas = 0; linhas < 5; linhas++)
            {
                int soma = 0;
                soma = SomarLinha(matint, linhas);
                Console.WriteLine($"Soma linha {linhas + 1} = {soma}");
                somatotal += soma; 
            }
            Console.WriteLine($"Soma total   = {somatotal}");
            Console.WriteLine();
        }

        void SomarColunas(int[,] matint)
        {
            int somatotal = 0;
            for (int colunas = 0; colunas < 5; colunas++)
            {
                int soma = 0;
                soma = SomarColuna(matint, colunas);
                Console.WriteLine($"Soma Coluna {colunas + 1} = {soma}");
                somatotal += soma;
            }
            Console.WriteLine($"Soma total   = {somatotal}");
            Console.WriteLine();
        }

        void SomarDiagonaldireita(int[,] matrizcalc)
        {
            int somar = 0; 
            for (int coluna = 4; coluna >= 0; coluna--)
            {
                int linhas = 4;
                somar += matrizcalc[linhas-coluna, coluna];
            }
            Console.WriteLine($"Soma Diagonal Direitabaixo: {somar}");
        }

        void SomarDiagonalesquerda(int[,] matrizcalc)
        {
            int somar = 0;
            for (int linhas = 0; linhas < 5; linhas++)
            {
                somar += matrizcalc[linhas, linhas];
            }
            Console.WriteLine($"Soma Diagonal EsquerdaCima: {somar}");
        }

        int SomarColuna(int[,] matrizcalc, int colunasomada)
        {
            int somarColunas = 0;
            for (int linhas = 0; linhas < 5; linhas++)
            {
                somarColunas += matrizcalc[linhas, colunasomada];
            }
            return somarColunas;
        }

        int SomarLinha(int[,] matrizcalc, int linhasomada)
        {
            int somarlinhas = 0;
            for (int colunas = 0; colunas < 5; colunas++)
            {
                somarlinhas += matrizcalc[linhasomada, colunas];
            }
            return somarlinhas;
        }

        int[,] InserirNúmeros(int[,] matint)
        {
            for (int linhas = 0; linhas < 5; linhas++)
            {
                Console.Clear();
                for (int colunas = 0; colunas < 5; colunas++)
                {
                    Console.Write($"Insira os valores da {linhas + 1} linha: ");
                    matint[linhas, colunas] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            for (int linhas = 0; linhas < 5; linhas++)
            {
                Console.WriteLine($"  {matint[linhas, 0]},{matint[linhas, 1]}," +
                    $"{matint[linhas, 2]},{matint[linhas, 3]},{matint[linhas, 4]} ");
            }
            return matint;
        }
    }
}