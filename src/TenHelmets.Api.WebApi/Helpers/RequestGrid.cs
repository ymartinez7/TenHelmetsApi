using Newtonsoft.Json;
using System.Collections.Generic;

namespace TenHelmets.API.WebApi.Helpers
{
    public class GridRequest
    {
        public FilterRequest Filter { get; set; }
        public List<SummariesRequest> Summaries { get; set; }
        public List<SortingRequest> Sorting { get; set; }
        public PagingRequest Paging { get; set; }
        public string GlobalSearch { get; set; }
        public string Export { get; set; }
    }

    public class FilterRequest
    {
        [JsonProperty(PropertyName = "filteringOperands")]
        public List<FilteringOperand> FilteringOperands { get; set; }
    }

    public class FilteringOperand
    {
        [JsonProperty(PropertyName = "filteringOperands")]
        public List<FilteringOperandInner> filteringOperands { get; set; }
    }

    public class FilteringOperandInner
    {
        [JsonProperty(PropertyName = "fieldName")]
        public string FieldName { get; set; }

        [JsonProperty(PropertyName = "condition")]
        public FilteringCondition Condition { get; set; }

        [JsonProperty(PropertyName = "searchVal")]
        public string SearchValue { get; set; }

        [JsonProperty(PropertyName = "ignoreCase")]
        public bool IgnoreCase { get; set; }
    }

    public class FilteringCondition
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "isUnary")]
        public bool IsUnary { get; set; }
    }

    public class SummariesRequest
    {
        [JsonProperty(PropertyName = "columnKey")]
        public string FieldName { get; set; }

        [JsonProperty(PropertyName = "summaryOperands")]
        public List<SummaryOperand> Operands { get; set; }
    }

    public class SummaryOperand
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }

    public class SortingRequest
    {
        [JsonProperty(PropertyName = "fieldName")]
        public string FieldName { get; set; }

        [JsonProperty(PropertyName = "dir")]
        public int Direction { get; set; }

        [JsonProperty(PropertyName = "ignoreCase")]
        public bool IgnoreCase { get; set; }
    }

    public class PagingRequest
    {
        [JsonProperty(PropertyName = "currentPage")]
        public int PageNumber { get; set; }

        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize { get; set; }
    }
}
