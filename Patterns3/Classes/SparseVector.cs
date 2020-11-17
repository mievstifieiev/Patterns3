using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3
{
    class SparseVector : IVector
    {
        private List<double> val;
        private int size;

        public int Size { get { return size; } }

        public SparseVector(int razm)
        {
            this.size = razm;
            this.val = new List<double>(size);
            for ( int i=0; i<size; i++)
            {
                val.Add(0);
            }
        }

        public List<double> GetAllValues()
        {
            return val;
        }

        public double GetValue(int i)
        {
            return val[i];
        }

        public void AddValue(double chisl)
        {
            val.Add(chisl);
            size++;
        }

        public void SetValue(int h, double chislo)
        {
            val[h] = chislo;
        }
        public double this[int index]
        {
            get { return val[index]; }
            set { val[index] = value; }
        }


    }
}
