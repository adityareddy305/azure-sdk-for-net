// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Search.Documents.Models
{
    internal partial class SearchDocumentsResult
    {
        internal static SearchDocumentsResult DeserializeSearchDocumentsResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? odataCount = default;
            double? searchCoverage = default;
            IReadOnlyDictionary<string, IList<FacetResult>> searchFacets = default;
            IReadOnlyList<QueryAnswerResult> searchAnswers = default;
            SearchOptions searchNextPageParameters = default;
            IReadOnlyList<SearchResult> value = default;
            string odataNextLink = default;
            SemanticErrorReason? searchSemanticPartialResponseReason = default;
            SemanticSearchResultsType? searchSemanticPartialResponseType = default;
            SemanticQueryRewritesResultType? searchSemanticQueryRewritesResultType = default;
            DebugInfo searchDebug = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("@search.coverage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchCoverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("@search.facets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IList<FacetResult>> dictionary = new Dictionary<string, IList<FacetResult>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            List<FacetResult> array = new List<FacetResult>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FacetResult.DeserializeFacetResult(item));
                            }
                            dictionary.Add(property0.Name, array);
                        }
                    }
                    searchFacets = dictionary;
                    continue;
                }
                if (property.NameEquals("@search.answers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchAnswers = null;
                        continue;
                    }
                    List<QueryAnswerResult> array = new List<QueryAnswerResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryAnswerResult.DeserializeQueryAnswerResult(item));
                    }
                    searchAnswers = array;
                    continue;
                }
                if (property.NameEquals("@search.nextPageParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchNextPageParameters = SearchOptions.DeserializeSearchOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<SearchResult> array = new List<SearchResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchResult.DeserializeSearchResult(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"u8))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@search.semanticPartialResponseReason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchSemanticPartialResponseReason = new SemanticErrorReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@search.semanticPartialResponseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchSemanticPartialResponseType = new SemanticSearchResultsType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@search.semanticQueryRewritesResultType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchSemanticQueryRewritesResultType = new SemanticQueryRewritesResultType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@search.debug"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchDebug = null;
                        continue;
                    }
                    searchDebug = DebugInfo.DeserializeDebugInfo(property.Value);
                    continue;
                }
            }
            return new SearchDocumentsResult(
                odataCount,
                searchCoverage,
                searchFacets ?? new ChangeTrackingDictionary<string, IList<FacetResult>>(),
                searchAnswers ?? new ChangeTrackingList<QueryAnswerResult>(),
                searchNextPageParameters,
                value,
                odataNextLink,
                searchSemanticPartialResponseReason,
                searchSemanticPartialResponseType,
                searchSemanticQueryRewritesResultType,
                searchDebug);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SearchDocumentsResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSearchDocumentsResult(document.RootElement);
        }
    }
}
