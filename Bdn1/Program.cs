using Bdn1;
using BenchmarkDotNet.Running;

namespace ListBenchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ListsBenchmark1>();
        }
    }
}
