namespace PracticalOOP.Srp
{
    internal class ObsucuringReference
    {
        private int[][] Data { get; set; }

        internal ObsucuringReference(int[][] data)
        {
            Data = data;
        }

        internal int[] Diameters()
        {
            return Array.ConvertAll(
                Data,
                // [0]: リム
                // [1]: タイヤ
                new Converter<int[], int>((d) => d[0] + d[1] * 2));
        }
    }
}
