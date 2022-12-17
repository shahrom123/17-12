            Mathematics m = new Mathematics();
            
            //abs 
            Console.WriteLine("Tabdili adadi manfi ba musbat");
            Console.Write("Adadi manfiro dokhil kuned: ");
            double value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Иваз ба адади мусбат: " + m.Abs(value));

            //pow
            Console.WriteLine("Darajabardorii yak adad bar adadi digar");
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x dar darajai y = "+ m.Pow(x, y));

            //sqrt
            Console.WriteLine("Resha az adad");
            Console.Write("d = ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Resha az d = " + m.Sqrt(d));

            //max
            Console.WriteLine("Khoriji adadi maksimali");
            Console.Write("val1 = ");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("val2 = ");
            int val2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max = " + m.Max(val1, val2));

            //min
            Console.WriteLine("Khoriji adadi minimali");
            Console.Write("num1 = ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("num2 = ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Min = " + m.Min(num1, num2));

            // const PI
            Console.WriteLine("Pi = " + Mathematics.PI);

            // const E
            Console.WriteLine("E = " + Mathematics.E);

            
