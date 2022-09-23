﻿using System.Drawing;
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
            throw new ArgumentOutOfRangeException();

        return decimal.MinusOne;
    }
}

