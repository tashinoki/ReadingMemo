using System.Drawing;
using System.Globalization;

namespace ReadingMemo.AdaptiveCode.Liskov;

internal class ShippingStrategy
{
    public decimal CalculateShippingCost(
        float packageWeight,
        Size packageDimensions,
        RegionInfo regionInfo
        )
    {
        if (packageWeight < 0)
            throw new ArgumentOutOfRangeException(nameof(packageWeight), "Package weight must be positive and nonzero");

        var shippingCost = decimal.MinusOne;

        if (shippingCost < 0)
            throw new ArgumentOutOfRangeException(nameof(shippingCost), "");

        return shippingCost;
    }
}

