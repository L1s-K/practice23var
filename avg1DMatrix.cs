namespace practice23var
{
    internal class avg1DMatrix
    {
        private int[] row;
        private double result;

        public int[] Row
        {
            set { row = value; }
            get { return row; }
        }

        public double Result
        {
            get
            {
                result = calculateAVG(row);
                return result;

            }
        }

        public avg1DMatrix(int[] inputRow)
        {
            row = inputRow;
        }

        private double calculateAVG(int[] input)
        {
            double temp = 0;
            for (int i = 0; i < input.Length; i++)
            {
                temp += input[i];
            }
            return Math.Round(temp / input.Length, 4);
        }

    }
}
