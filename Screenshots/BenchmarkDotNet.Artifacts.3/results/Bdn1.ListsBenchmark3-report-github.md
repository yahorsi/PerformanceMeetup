``` ini

BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.202
  [Host]     : .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT


```
|      Method |   N |     Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------ |---- |---------:|----------:|----------:|------:|--------:|------------:|------------:|------------:|--------------------:|
| Sum_ByIndex | 100 | 54.39 ns | 1.0685 ns | 1.0494 ns |  1.00 |    0.00 |           - |           - |           - |                   - |
| Sum_Foreach | 100 | 39.47 ns | 0.0883 ns | 0.0782 ns |  0.72 |    0.02 |           - |           - |           - |                   - |
