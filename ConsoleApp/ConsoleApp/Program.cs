using System.Net.Http.Headers;
using System.Text.Json;
using System.Collections.Generic;

using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/json"));
client.DefaultRequestHeaders.Add("User-Agent", "The man curious about the cats");

var catFact = await ProcessCatFactsAsync(client);

Console.WriteLine("Fact: " + catFact.Fact);
Console.WriteLine("Lenght: " + catFact.Length);

static async Task<CatFacts> ProcessCatFactsAsync(HttpClient client)
{
    await using Stream stream = await client.GetStreamAsync("https://catfact.ninja/fact");
    var catFact = await JsonSerializer.DeserializeAsync<CatFacts>(stream);
    //var catFact = await client.GetStringAsync("https://catfact.ninja/fact");
    return catFact;
}