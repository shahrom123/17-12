
 class Mathematics
    {
        public double Abs(double value)
        {

            return Convert.ToDouble(Math.Abs(value));
        }
    
        public short Abs(short value)
        {
            return Convert.ToInt16(Math.Abs(value));

        }
        int Abs(int value)
        {
            return Convert.ToInt32(Math.Abs(value));
        }

        public double Pow(double x, double y)
        {
            return Convert.ToDouble(Math.Pow(x, y));
        }

        public double Sqrt(double d)
        {
            return Convert.ToDouble(Math.Sqrt(d));
        }

        public int Max(int val1, int val2)
        {
            return Convert.ToInt32(Math.Max(val1, val2));
        }

        public int Min(int num1, int num2)
        {
            return Convert.ToInt32(Math.Min(num1,  num2));
        }

        public const double PI = 3.14;
        public const double E = 2.71;
    }
