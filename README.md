# ArticPolar.Dev.FetchData
Fetch Data from API (Or Other) Using TWO Methods: GET and POST

## Example
````
using System;
using ArticPolar.Dev.FetchData;

namespace FetchConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // URL da API JSONPlaceholder para testes
            string apiUrl = "https://jsonplaceholder.typicode.com/posts";

            // Conteúdo JSON para a solicitação POST (exemplo simples)
            string jsonContent = "{\"title\": \"Novo Post\", \"body\": \"Conteúdo do novo post\"}";

            FetchData apiFetcher = new FetchData();

            // Teste do método GET
            Console.WriteLine("Testando o método GET...");
            string getData = apiFetcher.Fetch(apiUrl);

            if (getData != null)
            {
                Console.WriteLine("Dados da API (GET):");
                Console.WriteLine(getData);
            }
            else
            {
                Console.WriteLine("Falha ao buscar dados da API (GET).");
            }

            // Teste do método POST
            Console.WriteLine("\nTestando o método POST...");
            string postData = apiFetcher.PostData(apiUrl, jsonContent);

            if (postData != null)
            {
                Console.WriteLine("Resposta da API (POST):");
                Console.WriteLine(postData);
            }
            else
            {
                Console.WriteLine("Falha ao fazer a solicitação POST para a API.");
            }
        }
    }
}
````

## Requeriments
Net Framework 4.7.1
