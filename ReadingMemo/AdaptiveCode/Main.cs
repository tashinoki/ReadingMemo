using System.Drawing;
using System.Globalization;
using ReadingMemo.AdaptiveCode.Liskov;
using ReadingMemo.AdaptiveCode.Liskov.Infrastructure;

namespace ReadingMemo.AdaptiveCode
{
    internal static class Main
    {
        public static void Run()
        {
            var shippingStrategy = new ShippingStrategy();
            shippingStrategy.CalculateShippingCost(1000, new Size(10, 10), new RegionInfo("ja-JP"));

            IEntityRepository<User> repository = new UserRepository();
            var entity = repository.GetById(Guid.NewGuid());
        }
    }
}
