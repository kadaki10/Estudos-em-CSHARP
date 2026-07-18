using System.ComponentModel;
using Estudos_C__.net.Models;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas gerais");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Add("BA2", "Bahia");























// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o item da pilha {pilha.Pop()}");

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

//string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//Console.WriteLine("Chegou até aqui");


// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/d/arquivo_Leitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// } 
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine("Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado")
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção generica. {ex.Message}");
// }


// Console.WriteLine("Chegou até aqui");



// string dataString = "2022-04-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }

// else
// {
//     Console.WriteLine($"{dataString} não é uma data valida!");
// }

// DateTime data = DateTime.Parse("32/04/2022 18:00");

// Console.WriteLine(data);

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));


// Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

// Curso CursoDeIngles = new Curso();
// CursoDeIngles.Nome = "Ingles";
// CursoDeIngles.Alunos = new List<Pessoa>();

// CursoDeIngles.AdicionarAluno(p1);
// CursoDeIngles.AdicionarAluno(p2);
// CursoDeIngles.ListarAlunos();

// Pessoa p1 = new Pessoa();
// p1.Nome = "kadaki";
// p1.Idade = 29;
// p1.Apresentar();


// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// int[] arrayInteirosDobrado =  new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo o ARRAY com o FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
// }


// Console.WriteLine("Percorrendo o ARRAY com o FOREACH");

// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
//     contadorForeach++;
// }




// string opcao;
// bool exibirMenu = true;


// while(exibirMenu)
// {   
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
        
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             //Environment.Exit(0);
//             break;    

//         default:
//             Console.WriteLine("Opção invalida");
//             break;
//     }
// }




// int soma = 0, numero = 0;


// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;
// } while(numero != 0);

// Console.WriteLine($"Total das somas digitados é: {soma}");


// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }


// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine("Incrementando o 10");
// // numero = numero + 1;
// numeroIncremento++;

// int numeroDecremento = 20;

// Console.WriteLine("Decrementando o 20");
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);

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
