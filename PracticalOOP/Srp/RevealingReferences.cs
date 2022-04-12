namespace PracticalOOP.Srp
{
    internal class RevealingReferences
    {
        private Wheel[] Wheels { get; set; }

        internal RevealingReferences(int[][] data)
        {
            Wheels = Wheelify(data);
        }

        public int Diameter(int rim, int tire)
            => rim + tire * 2;

        internal int[] Diameters()
            => Array.ConvertAll(
                Wheels,
                new Converter<Wheel, int>((w) => Diameter(w.Rim, w.Tire)));

        private Wheel[] Wheelify(int[][] data)
            => Array.ConvertAll(
                data,
                new Converter<int[], Wheel>((d => new Wheel(d[0], d[1]))));

        private record Wheel(int Rim, int Tire)
        {
        }
    }
}
