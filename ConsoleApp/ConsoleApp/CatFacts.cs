using System.Text.Json.Serialization;
    public record class CatFacts(
        [property: JsonPropertyName("fact")] string Fact,
        [property: JsonPropertyName("length")] int Length
        );

