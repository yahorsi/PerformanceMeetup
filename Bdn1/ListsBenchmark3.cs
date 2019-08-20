using System.Linq;
using System.Collections.Generic;

using BenchmarkDotNet.Attributes;
using System;

namespace Bdn1
{
    //[InliningDiagnoser]
    //[TailCallDiagnoser]
    //[EtwProfiler]
    //[ConcurrencyVisualizerProfiler]
    [MemoryDiagnoser]
    [DisassemblyDiagnoser(printAsm: true, printIL: true, printSource: true)]
    public class ListsBenchmark3
    {
        private byte[] _data;

        [Params(100)]
        public int N { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            _data = new byte[N];

            // Answer to the Ultimate Question of Life
            new Random(42).NextBytes(_data);
        }

        [Benchmark(Baseline = true)]
        public int Sum_ByIndex()
        {
            int sum = 0;
            for (int i = 0; i < _data.Length; ++i)
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
    }
}
