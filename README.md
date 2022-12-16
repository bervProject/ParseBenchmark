# Parse Benchmark

## Int Parse/Convert

|         Method |  Number |     Mean |    Error |   StdDev |   Median |
|--------------- |-------- |---------:|---------:|---------:|---------:|
| ConvertToInt32 |      -1 | 15.89 ns | 0.331 ns | 0.325 ns | 15.93 ns |
|     Int32Parse |      -1 | 18.63 ns | 0.403 ns | 0.627 ns | 18.85 ns |
|       IntParse |      -1 | 16.60 ns | 0.252 ns | 0.236 ns | 16.60 ns |
| ConvertToInt32 |     -10 | 16.93 ns | 0.380 ns | 0.452 ns | 16.86 ns |
|     Int32Parse |     -10 | 16.87 ns | 0.364 ns | 0.498 ns | 17.00 ns |
|       IntParse |     -10 | 16.94 ns | 0.189 ns | 0.167 ns | 16.92 ns |
| ConvertToInt32 |       1 | 18.07 ns | 0.392 ns | 0.843 ns | 17.97 ns |
|     Int32Parse |       1 | 16.28 ns | 0.237 ns | 0.198 ns | 16.31 ns |
|       IntParse |       1 | 18.06 ns | 0.276 ns | 0.258 ns | 18.03 ns |
| ConvertToInt32 |      10 | 17.67 ns | 0.385 ns | 0.360 ns | 17.71 ns |
|     Int32Parse |      10 | 16.39 ns | 0.196 ns | 0.163 ns | 16.32 ns |
|       IntParse |      10 | 18.00 ns | 0.292 ns | 0.259 ns | 18.01 ns |
| ConvertToInt32 |    1000 | 18.85 ns | 0.393 ns | 0.794 ns | 18.52 ns |
|     Int32Parse |    1000 | 18.34 ns | 0.144 ns | 0.112 ns | 18.40 ns |
|       IntParse |    1000 | 18.31 ns | 0.409 ns | 0.625 ns | 18.01 ns |
| ConvertToInt32 |   10000 | 18.49 ns | 0.243 ns | 0.228 ns | 18.48 ns |
|     Int32Parse |   10000 | 18.09 ns | 0.180 ns | 0.168 ns | 18.06 ns |
|       IntParse |   10000 | 20.24 ns | 0.435 ns | 0.427 ns | 20.15 ns |
| ConvertToInt32 |  100000 | 18.92 ns | 0.200 ns | 0.187 ns | 18.89 ns |
|     Int32Parse |  100000 | 19.60 ns | 0.119 ns | 0.099 ns | 19.63 ns |
|       IntParse |  100000 | 21.51 ns | 0.161 ns | 0.151 ns | 21.54 ns |
| ConvertToInt32 | 1000000 | 20.57 ns | 0.185 ns | 0.173 ns | 20.63 ns |
|     Int32Parse | 1000000 | 22.56 ns | 0.210 ns | 0.197 ns | 22.54 ns |
|       IntParse | 1000000 | 22.28 ns | 0.275 ns | 0.257 ns | 22.21 ns |

## Legends

* Number : Value of the 'Number' parameter
* Mean   : Arithmetic mean of all measurements
* Error  : Half of 99.9% confidence interval
* StdDev : Standard deviation of all measurements
* Median : Value separating the higher half of all measurements (50th percentile)
* 1 ns   : 1 Nanosecond (0.000000001 sec)

## LICENSE

MIT

```
Copyright 2022 Bervianto Leo Pratama

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```
