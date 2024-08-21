using BenchmarkDotNet.Running;
using Benchmarks;

Console.WriteLine("Running Benchmarks");
var summary = BenchmarkRunner.Run<CollectionBenchmarks>();
Console.WriteLine(summary);
