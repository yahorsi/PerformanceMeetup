using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Toolchains.CsProj;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;

namespace Bdn1
{
    public class BenchmarkConfig : ManualConfig
    {
        private const string JitTieredCompilation = "COMPLUS_TieredCompilation";

        public BenchmarkConfig()
        {
            Add(MemoryDiagnoser.Default);
            Add(DisassemblyDiagnoser.Create(
                new DisassemblyDiagnoserConfig(
                    printAsm: true,
                    printIL: true,
                    printSource: true)));
            Add(AsciiDocExporter.Default);

            Add(Job.Core
                .With(CsProjCoreToolchain.NetCoreApp22)
                .With(new[] { new EnvironmentVariable(JitTieredCompilation, "1") })
                .WithGcServer(true)
                .WithId("CsProjCoreToolchain.NetCoreApp22"));

            Add(Job.Core
                .With(CsProjCoreToolchain.NetCoreApp30)
                .With(new[] { new EnvironmentVariable(JitTieredCompilation, "1") })
                .WithGcServer(true)
                .WithId("CsProjCoreToolchain.NetCoreApp30"));

            Add(Job.Core
                .With(CsProjClassicNetToolchain.Net472)
                .WithGcServer(true)
                .WithId("CsProjClassicNetToolchain.Net472"));
        }
    }

    [Config(typeof(BenchmarkConfig))]
    //[Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class ListsBenchmark4
    {
        private byte[] _byteData;

        [Params(1000)]
        public int N { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            _byteData = new byte[N];

            for (int i = 0; i < _byteData.Length; ++i)
            {
                _byteData[i] = (byte)i;
            }
        }

        [Benchmark]
        public int byte_sum_ByIndex()
        {
            int sum = 0;
            for (int i = 0; i < _byteData.Length; ++i)
            {
                sum += _byteData[i];
            }

            return sum;
        }

        [Benchmark(Baseline = true)]
        public int byte_sum_Foreach()
        {
            int sum = 0;
            foreach (var n in _byteData)
            {
                sum += n;
            }

            return sum;
        }
    }
}
