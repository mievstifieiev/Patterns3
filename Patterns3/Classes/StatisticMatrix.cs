using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3
{
    class StatisticMatrix
    {
        public double SumAllElements { get; }
        public double AverageVal { get; }
        public double MaxVal { get; }
        public int NotNulCount { get; }
        public StatisticMatrix(SomeMatrix some)
        {
            for (int i = 0; i < some.row_count;i++ )
                for (int j = 0; j < some.column_count; j++)
                {
                    SumAllElements += some.GetValue(i, j);
                    if (some.GetValue(i, j)> MaxVal)
                    {
                        MaxVal = some.GetValue(i, j);
                    }
                    if (some.GetValue(i, j)!=0)
                    {
                        NotNulCount++;
                    }
                }

            AverageVal = SumAllElements / (some.row_count * some.column_count);
            
        }

        public void StatPrint()
        {
            Console.Write(" SumAllElements = " + this.SumAllElements + ", AverageVal = "
                + this.AverageVal + ", MaxVal = " + this.MaxVal + ", NotNulCount = " + this.NotNulCount + "\n");
        }
    }
}
