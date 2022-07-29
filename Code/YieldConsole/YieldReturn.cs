namespace YieldConsole
{
    public static class YieldReturn
    {
        public static IEnumerable<Person> GetPeople(int quantity)
        {
            Console.WriteLine("GetPeople");

            List<Person> people = new();

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Adding Person-{i}");
                people.Add(new Person { Id = i, FirstName = $"FirstName{i}", LastName = $"LastName{i}" });
            }

            return people;
        }

        public static IEnumerable<Person> GetPeopleYield(int quantity)
        {
            Console.WriteLine("GetPeopleYield");

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Adding Person-{i}");
                yield return new Person { Id = i, FirstName = $"FirstName{i}", LastName = $"LastName{i}" };
            }
        }

    }
}