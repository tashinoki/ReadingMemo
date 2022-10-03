using System.Drawing;
using System.Globalization;
using ReadingMemo.AdaptiveCode.Liskov;

namespace ReadingMemo.AdaptiveCode
{
    internal static class Main
    {
        public static void Run()
        {
            var shippingStrategy = new ShippingStrategy();
            shippingStrategy.CalculateShippingCost(1000, new Size(10, 10), new RegionInfo("ja-JP"));
        }
    }
}
