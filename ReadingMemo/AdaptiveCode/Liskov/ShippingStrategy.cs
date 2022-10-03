using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;

namespace ReadingMemo.AdaptiveCode.Liskov;

internal class ShippingStrategy
{
    private decimal _flatRate;

    public decimal FlatRate
    {
        get => _flatRate;
        set
        {
            if(value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "");

            _flatRate = value;
        }
    }

    public decimal CalculateShippingCost(
        float packageWeight,
        Size packageDimensions,
        RegionInfo regionInfo
        )
    {
        if (packageWeight < 0)
            throw new ArgumentOutOfRangeException(nameof(packageWeight), "Package weight must be positive and nonzero");
        //Contract.Requires<ArgumentOutOfRangeException>(
        //    packageWeight > 0,
        //    "Package weight must be positive and nonzero");

        var shippingCost = decimal.MinusOne;

        if (shippingCost < 0)
            throw new ArgumentOutOfRangeException(nameof(shippingCost), "");
        //Contract.Ensures(Contract.Result<decimal>() > 0);

        return shippingCost;
    }
}

internal class WorldWideShippingCost : ShippingStrategy
{
    public new decimal FlatRate
    {
        get => base.FlatRate;
        set => base.FlatRate = value;
    }
}