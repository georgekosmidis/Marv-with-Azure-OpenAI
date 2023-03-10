﻿using System.Text.Json.Serialization;

namespace AzureOpenAISample.Models;
public class OpenAIResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("object")]
    public string? Object { get; set; }

    [JsonPropertyName("created")]
    public int Created { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("choices")]
    public List<OpenAIResponseChoice>? Choices { get; set; }

    [JsonPropertyName("usage")]
    public OpenAIResponseUsage? Usage { get; set; }
}
