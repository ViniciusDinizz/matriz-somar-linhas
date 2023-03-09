internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matint = new int[5, 5];
        Random aleatorio = new Random();

        matint = InserirNúmeros(matint);

        //Chamada de funções
        SomarLinhas(matint);

        SomarColunas(matint);

        SomarDiagonaldireita(matint);
        SomarDiagonalesquerda(matint);

        //Chama a função SomaLinha1 para calcular as linhas indiviaduais, e soma o total delas
        void SomarLinhas(int[,] matint)
        {
            int somatotal = 0;
            for (int linhas = 0; linhas < matint.GetLength(0); linhas++)
            {
                int soma = 0;
                soma = SomarLinha1(matint, linhas);
                Console.WriteLine($"Soma linha {linhas + 1} = {soma}");
                somatotal += soma;
            }
            Console.WriteLine($"Soma total   = {somatotal}");
            Console.WriteLine();
        }

        //Chama a função SomarColuna1 para calcular as colunas individuais, e soma o total delas
        void SomarColunas(int[,] matint)
        {
            int somatotal = 0;
            for (int colunas = 0; colunas < matint.GetLength(1); colunas++)
            {
                int soma = 0;
                soma = SomarColuna1(matint, colunas);
                Console.WriteLine($"Soma Coluna {colunas + 1} = {soma}");
                somatotal += soma;
            }
            Console.WriteLine($"Soma total    = {somatotal}");
            Console.WriteLine();
        }

        //Sma a diagonal de uma matriz quadrada
        void SomarDiagonaldireita(int[,] matrizcalc)
        {
            int somar = 0;
            for (int coluna = matrizcalc.GetLength(1) - 1; coluna >= 0; coluna--)
            {
                int linhas = matrizcalc.GetLength(0) - 1;
                somar += matrizcalc[linhas - coluna, coluna];
            }
            Console.WriteLine($"Soma Diagonal 1: {somar}");
        }

        //Soma a diagonal inversa de uma matriz quadrada
        void SomarDiagonalesquerda(int[,] matrizcalc)
        {
            int somar = 0;
            for (int linhas = 0; linhas < matrizcalc.GetLength(0); linhas++)
            {
                somar += matrizcalc[linhas, linhas];
            }
            Console.WriteLine($"Soma Diagonal 2: {somar}");
        }

        //Soma cada coluna separadamente
        int SomarColuna1(int[,] matrizcalc, int colunasomada)
        {
            int somarColunas = 0;
            for (int linhas = 0; linhas < matrizcalc.GetLength(0); linhas++)
            {
                somarColunas += matrizcalc[linhas, colunasomada];
            }
            return somarColunas;
        }

        //Soma cada linha separadamente
        int SomarLinha1(int[,] matrizcalc, int linhasomada)
        {
            int somarlinhas = 0;
            for (int colunas = 0; colunas < matrizcalc.GetLength(1); colunas++)
            {
                somarlinhas += matrizcalc[linhasomada, colunas];
            }
            return somarlinhas;
        }

        //Grava números aleatórios em uma matriz quadrada
        int[,] InserirNúmeros(int[,] matint)
        {
            for (int linhas = 0; linhas < matint.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < matint.GetLength(1); colunas++)
                {
                    matint[linhas, colunas] = aleatorio.Next(100, 1000); //sorteando de 0 á 999
                }
            }
            Console.Clear();
            for (int linhas = 0; linhas < matint.GetLength(0); linhas++)
            {
                Console.WriteLine($"  {matint[linhas, 0]} | {matint[linhas, 1]} | " +
                    $"{matint[linhas, 2]} | {matint[linhas, 3]} | {matint[linhas, 4]} ");
            }
            return matint;
        }
    }
}