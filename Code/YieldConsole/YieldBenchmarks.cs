using BenchmarkDotNet.Attributes;

namespace YieldConsole
{
    //[MemoryDiagnoser]
    [SimpleJob(launchCount: 3, warmupCount: 10, targetCount: 30)]
    public class YieldBenchmarks
    {
        [Benchmark]
        public void ProcessPeople()
        {
            var people = GetPeople(YieldDefine.QUANTITY);

            //Console.WriteLine("Process People");

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Id}, {person.FirstName}, {person.LastName}");
            }
        }

        private IEnumerable<Person> GetPeople(int quantity)
        {
            //Console.WriteLine("GetPeople");

            List<Person> people = new();

            for (int i = 0; i < quantity; i++)
            {
                //Console.WriteLine($"Adding Person-{i}");
                people.Add(new Person { Id = i, FirstName = $"FirstName{i}", LastName = $"LastName{i}" });
            }

            return people;
        }

        [Benchmark]
        public void ProcessPeopleYield()
        {
            var people = GetPeopleYield(YieldDefine.QUANTITY);

            //Console.WriteLine("Process People-Yield");

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Id}, {person.FirstName}, {person.LastName}");
            }
        }



        private IEnumerable<Person> GetPeopleYield(int quantity)
        {
            //Console.WriteLine("GetPeopleYield");

            for (int i = 0; i < quantity; i++)
            {
                //Console.WriteLine($"Adding Person-{i}");
                yield return new Person { Id = i, FirstName = $"FirstName{i}", LastName = $"LastName{i}" };
            }
        }
    }
}