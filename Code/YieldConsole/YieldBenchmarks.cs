using BenchmarkDotNet.Attributes;

namespace YieldConsole
{
    [MemoryDiagnoser]
    public class YieldBenchmarks
    {
        [Benchmark]
        public void ProcessPeople()
        {
            var people = YieldReturn.GetPeople(YieldDefine.QUANTITY);

            Console.WriteLine("Process People");

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Id}, {person.FirstName}, {person.LastName}");
            }
        }

        [Benchmark]
        public void ProcessPeopleYield()
        {
            var people = YieldReturn.GetPeopleYield(YieldDefine.QUANTITY);

            Console.WriteLine("Process People-Yield");

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Id}, {person.FirstName}, {person.LastName}");
            }
        }

    }
}