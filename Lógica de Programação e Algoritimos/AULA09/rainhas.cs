 using static System.Console;
//PROBLEMA N RAINHAS
static bool podeColocar(int tabuleiro, int linha, int coluna, int n)
{
    for (int i = 0 ; i < linha; i++)
    {
        if (tabuleiro == coluna | (tabuleiro - i ) == (coluna - linha ) | (tabuleiro + i ) == (coluna + linha))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}

static bool resolverNRainhas (int tabuleiro, int linha , int coluna , int n)
{
    if (linha == n)
    {
        System.Console.WriteLine(tabuleiro);
        return true;
    }

    for(coluna; coluna<n; coluna ++)
    {
        if (podeColocar(tabuleiro, linha, coluna, n))
        {
            tabuleiro[linha] = coluna;
            resolverNRainhas(tabuleiro, linha + 1, 0, n);
        }
    }
}


int n;
//processamento de dados 
