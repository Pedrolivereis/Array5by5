int[] numeros = new int [4];
int contador;
void PopulaVetor()
{
    do
    {
        contador = 0;
        Console.WriteLine($"Informe o numero desejado na posição {contador}: ");
        numeros[contador] = int.Parse(Console.ReadLine());
        contador++;
    } while (contador < numeros.Length);
}

