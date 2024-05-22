using BlazorApp.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace BlazorApp
{
    public class WriteToFile
    {
        //private readonly string _filePath;
        static string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string _filePath = Path.Combine(docPath, "D:\\111111\\hobby\\programowanie\\NetwiseRecruitmentApp\\BlazorApp\\titbits.txt");

        public async Task SaveCatFactAsync(CatFact catFact)
        {
            await using StreamWriter outputFile = new StreamWriter(_filePath, true);
            {
                await outputFile.WriteLineAsync($"Fact: {catFact.fact} | Length: {catFact.length}");
            }
        }
    }
}
