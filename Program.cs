// Este programa tem como objetivo modelar a classe Carros e realizar a desserialização dos dados
// obtidos de um endpoint específico. A classe Carros reflete a estrutura dos dados retornados
// pelo endpoint, permitindo a manipulação e uso desses dados em diferentes partes da aplicação.
using CarrosDesserializar;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://github.com/ArthurOcFernandes/Exerc-cios-C-/raw/curso-4-aula-2/Jsons/Carros.json");
        var carros = JsonSerializer.Deserialize<List<Carro>>(resposta);

        foreach (var carro in carros)
        {
            Console.WriteLine(carro.Informacoes); 
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}