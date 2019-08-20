``` ini

BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.202
  [Host]     : .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT


```
|      Method |  N |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------------ |--- |-----------:|----------:|----------:|------:|--------:|
| **Sum_ByIndex** | **15** |   **7.948 ns** | **0.1065 ns** | **0.0997 ns** |  **1.00** |    **0.00** |
| Sum_Foreach | 15 |   4.212 ns | 0.0876 ns | 0.0819 ns |  0.53 |    0.01 |
|    Sum_Linq | 15 | 109.813 ns | 2.4948 ns | 3.4974 ns | 14.01 |    0.56 |
|             |    |            |           |           |       |         |
| **Sum_ByIndex** | **30** |  **14.140 ns** | **0.2949 ns** | **0.3156 ns** |  **1.00** |    **0.00** |
| Sum_Foreach | 30 |   8.852 ns | 0.0615 ns | 0.0575 ns |  0.63 |    0.02 |
|    Sum_Linq | 30 | 192.124 ns | 1.9401 ns | 1.7198 ns | 13.57 |    0.39 |
