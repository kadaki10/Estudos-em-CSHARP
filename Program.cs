using System.Data.Common;
using Estudos_C__.net.Models;

Calculadora calc = new Calculadora();

int numeroIncremento = 10;

Console.WriteLine(numeroIncremento);

Console.WriteLine("Incrementando o 10");
// numero = numero + 1;
numeroIncremento++;

int numeroDecremento = 20;

Console.WriteLine("Decrementando o 20");
numeroDecremento--;

Console.WriteLine(numeroDecremento);
























// calc.Potencia(3, 3);
// calc.Tangente(30);


// calc.Somarrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);


// bool choveu = false;
// bool estaTarde = true;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar de bike!");
// }
// else
// {
//     Console.WriteLine("Vou ficar em casa.");
// }



// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }



// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada negada!");
// }




// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
    
//     default:
//         Console.WriteLine("Não é vogal");
//         break;
// }



// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");


// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda invalida!");
// }

// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade em estoque.");
// }




//string a = "15-1";

//int b = 0;

// int.TryParse(a, out int b);


//Console.WriteLine(b);
//Console.WriteLine("Conversão realizada com sucesso!");







// Cast - Casting
// int a = Convert.ToInt32("5");
// int a = int.Parse("5c");

// Console.WriteLine(a);






// int a = 10;
// int b = 20;

// int c = a + b;

// // c = c + 5; // 30 + 5

// //c += 5;

// // c = c - 5
// c *= 5;
// Console.WriteLine(c);











// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:MM"));



// string apresentacao = "Olá, seja bem vindo!";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80m;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variavel preco: " + preco);
// Console.WriteLine("Valor da variavel condicao: " + condicao);

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Reinaldo";
// pessoa1.Idade = 29;
// pessoa1.Apresentar();
