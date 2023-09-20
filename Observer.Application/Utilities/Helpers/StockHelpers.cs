using Observer.Domain.Models;

namespace Observer.Application.Utilities.Helpers
{
    public static class StockHelpers
    {
        public static int? GetDaysFromLastDiscount(this StockInPlace stockInPlace)
        {
            if (stockInPlace.LastDiscounted == null) return null;

            TimeSpan dateDiff = DateTime.UtcNow - stockInPlace.LastDiscounted.Value;
            var result = dateDiff.Days;

            return result;
        }
    }
}
