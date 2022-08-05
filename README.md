# YieldSamples
 How to use Yields in .Net

Quantity = 1000
|             Method |     Mean |   Error |   StdDev | Allocated |
|------------------- |---------:|--------:|---------:|----------:|
|      ProcessPeople | 378.8 ms | 7.51 ms | 14.46 ms |    290 KB |
| ProcessPeopleYield | 390.2 ms | 8.05 ms | 23.22 ms |    273 KB |


Quantity = 10000
|             Method |    Mean |    Error |   StdDev | Allocated |
|------------------- |--------:|---------:|---------:|----------:|
|      ProcessPeople | 3.924 s | 0.0756 s | 0.0743 s |      3 MB |
| ProcessPeopleYield | 3.933 s | 0.0757 s | 0.0810 s |      3 MB |

Quantity = 100000

|             Method |    Mean |   Error |  StdDev |     Gen 0 | Allocated |
|------------------- |--------:|--------:|--------:|----------:|----------:|
|      ProcessPeople | 38.45 s | 0.465 s | 0.435 s | 1000.0000 |     31 MB |
| ProcessPeopleYield | 37.88 s | 0.273 s | 0.255 s | 1000.0000 |     29 MB |
