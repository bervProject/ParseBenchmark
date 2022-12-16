using BenchmarkDotNet.Attributes;

namespace ParseBenchmark;

public class ParseBenchmark
{
    [Params("-10", "-1", "1", "10", "1000", "10000", "100000", "1000000")]
    public string Number { get; set; }

    [Benchmark]
    public int ConvertToInt32() => Convert.ToInt32(Number);

    [Benchmark]
    public int Int32Parse() => Int32.Parse(Number);

    [Benchmark]
    public int IntParse() => int.Parse(Number);
}