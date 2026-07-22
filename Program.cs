using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5] {6, 3, 8, 1, 9};
            int[] arrayCopia = new int[10];
            string[] arrayString = op.ConverterParaArrayString(array);

            //int valorProcurado = 8;

            System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

            op.RedimensionarArray(ref array, array.Length * 2);

            System.Console.WriteLine($"Capacidade atual do Array após redimensionar: {array.Length} ");



            // int indice = op.ObterIndice(array, valorProcurado);

            // if(indice > -1)
            // {
            //     System.Console.WriteLine($"O indice do elemento {valorProcurado} é: {indice}");
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor inexistente do array");
            // }

            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não encontrado");
            // }



            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if(todosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores são maior que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existe valores que não são maiores do que {0}", valorProcurado);
            // }
            

            // bool existe = op.Existe(array, valorProcurado);

            // if (existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }

            // System.Console.WriteLine("Array original: ");
            // op.ImprimirArray(array);

            // //op.OrdenarBubbleSort(ref array);
            // //op.Ordenar(ref array);

            // System.Console.WriteLine("Array ordenado");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da copia:");
            // op.ImprimirArray(arrayCopia);
            
            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array após a copia");
            // op.ImprimirArray(arrayCopia);
        }
    }
}