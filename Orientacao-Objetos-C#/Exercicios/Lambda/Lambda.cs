// função convencional
using System.Reflection.Metadata.Ecma335;

int Somar(int a, int b)
{
    int resultado = a + b;
    return resultado;
}

// função lambda
int Somar(int a, int b) => a + b;