namespace SparseBinaryDecomposition
{
    public static class Main
    {
        public static int Solution(int N)
        {
            if (IsSparse(N & 0x55555555))
                return N & 0x55555555;
            else if (IsSparse(N & 0xAAAAAAA))
                return (N & 0xAAAAAAA);
            else
                return -1;
        }
        private static bool IsSparse(int x)
        {
            return (x & (x >> 1)) == 0;
        }

    }
}
