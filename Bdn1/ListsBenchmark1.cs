using System.Linq;
using System.Collections.Generic;

using BenchmarkDotNet.Attributes;


namespace Bdn1
{
    public class ListsBenchmark1
    {
        private List<int> _data;

        [GlobalSetup]
        public void Setup()
        {
            _data = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        }

        [Benchmark]
        public int Sum_ByIndex()
        {
            int sum = 0;
            for (int i = 0; i < _data.Count; ++i)
            {
                sum += _data[i];
            }

            return sum;
        }

        [Benchmark]
        public int Sum_Foreach()
        {
            int sum = 0;
            foreach (var n in _data)
            {
                sum += n;
            }

            return sum;
        }

        [Benchmark]
        public int Sum_Linq()
        {
            return _data.Sum();
        }
    }
}
