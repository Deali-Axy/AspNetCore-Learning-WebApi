using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using Library.Api.Helpers;

namespace Library.Api.Extensions {
    public static class QueryableExtension {
        private const string OrderSequenceAsc = "asc";
        private const string OrderSequenceDesc = "desc";

        public static IQueryable<T> Sort<T>(this IQueryable<T> source,
            string orderBy,
            Dictionary<string, PropertyMapping> mappings) where T : class {
            var allQueryParts = orderBy.Split(',');
            var sortParts = new List<string>();
            foreach (var item in allQueryParts) {
                var property = string.Empty;
                bool isDescending = false;
                if (item.ToLower().EndsWith(OrderSequenceDesc)) {
                    property = item.Substring(0, item.Length - OrderSequenceDesc.Length).Trim();
                    isDescending = true;
                }
                else {
                    property = item.Trim();
                }

                if (mappings.ContainsKey(property)) {
                    if (mappings[property].IsRevert) isDescending = !isDescending;

                    sortParts.Add(isDescending
                        ? $"{mappings[property].TargetProperty} {OrderSequenceDesc}"
                        : $"{mappings[property].TargetProperty} {OrderSequenceAsc}");
                }
            }

            var finalExpression = string.Join(',', sortParts);
            source = source.OrderBy(finalExpression);
            return source;
        }
    }
}