using System;
using System.Text;

namespace MyAppStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder();
        }

        static void InterpolacaoDeString() //função criada apenas para dividir as matérias de estudo no código
        {

            var preco = 10.2;
            var texto = "O preço do produto é R$" + preco + " apenas na promoção";

            var texto2 = string.Format("O preço do produto é {0} apenas na promoção", preco);      //Format: formata a cadeia de characters

            var texto3 = $@"O preço do produto é {preco} apenas na promoção";       //o "@" os characters de escape. "\n" por exemplo

            Console.WriteLine(texto3);
        }

        static void ComparacaoDeStrings()
        {
            var texto = "Testando";                               //CompareTo: retorna sempre 0 ou 1
            Console.WriteLine(texto.CompareTo("Testando"));       //CompareTo: compara a string com algum outro objeto
            Console.WriteLine(texto.CompareTo("testando"));

            texto = "Este texto é um teste";                   //Contains retorna sempre True ou False
            Console.WriteLine(texto.Contains("teste"));        //Contain: retorna se a string tem de fato um texto
            Console.WriteLine(texto.Contains("Teste"));        //irá retornar falso por causa do case sensitive
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); //StringComparison.OrdinalIgnoreCase irá ignorar o case sensitive


        }

        static void StartWithEndWith()
        {
            var texto = "Este texto é um teste";            //Compara se o texto começa com a palavra
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("texto"));

            Console.WriteLine(texto.EndsWith("teste"));     //Compara se o texto termina com a palavra
            Console.WriteLine(texto.EndsWith("Teste"));
            Console.WriteLine(texto.EndsWith("texto"));
        }

        static void Equals()
        {
            var texto = "Este texto é um teste";            //Compara se o texto é exatamente igual
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
        }

        static void Indice()
        {
            var texto = "Este texto é um teste";     //Indica a posição de um caracter ou de um item dentro de uma lista 
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.LastIndexOf("s")); //Indica a ultima letra "s" na frase

        }

        static void MetodosAdicionais()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.ToUpper());     //Transforma o texto todo em MAIUSCULO
            Console.WriteLine(texto.ToLower());     //Transforma o texto todo em minusculo

            Console.WriteLine(texto.Insert(5, "AQUI "));      //Insere um character no meio do texto
            Console.WriteLine(texto.Remove(5, 5));            //Remove o character no meio do texto
            Console.WriteLine(texto.Length);                  //Retorna a quantidade de character da frase
        }

        static void ManipulandoStrings()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Replace("Este", "isto"));       //Troca palavras e character por outro

            var divisao = texto.Split(" ");     //divide o texto
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            var resultado = texto.Substring(5, 5);
            Console.WriteLine(resultado);

            Console.WriteLine(texto.Trim());        //remove os espaços do começo e do final da string
                                                    //muito util para quando esta se criando um formulario de login
        }

        static void StringBuilder()
        {
            var texto = new StringBuilder();
            texto.Append("Este texto é um teste");
            texto.Append("é um teste");
            texto.Append("Este texto");
            texto.Append("Este é um teste");

            Console.WriteLine(texto);
        }
    }
}