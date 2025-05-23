﻿using System.Text.Json.Serialization;
using Betalgo.Ranul.OpenAI.ObjectModels.SharedModels;

namespace Betalgo.Ranul.OpenAI.ObjectModels.ResponseModels;

public record CompletionCreateResponse : BaseResponse, IOpenAIModels.IId, IOpenAIModels.ICreatedAt
{
    [JsonPropertyName("model")]
    public string Model { get; set; }

    [JsonPropertyName("choices")]
    public List<ChoiceResponse> Choices { get; set; }

    [JsonPropertyName("usage")]
    public UsageResponse Usage { get; set; }

    [JsonPropertyName("created")]
    public long CreatedAtUnix { get; set; }

    public DateTimeOffset CreatedAt => DateTimeOffset.FromUnixTimeSeconds(CreatedAtUnix);

    [JsonPropertyName("id")]
    public string Id { get; set; }
}