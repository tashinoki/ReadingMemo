namespace PracticalOOP.Srp
{
    internal class RevealingReferences
    {
        private Wheel[] Wheels { get; set; }

        internal RevealingReferences(int[][] data)
        {
            Wheels = Wheelify(data);
        }

        internal int[] Diameters()
            => Array.ConvertAll(
                Wheels,
                new Converter<Wheel, int>((w) => w.Rim + w.Tire * 2));

        private Wheel[] Wheelify(int[][] data)
            => Array.ConvertAll(
                data,
                new Converter<int[], Wheel>((d => new Wheel(d[0], d[1]))));

        private record Wheel(int Rim, int Tire)
        {
        }
    }
}
