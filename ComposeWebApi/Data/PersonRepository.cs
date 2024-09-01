namespace ComposeWebApi.Data
{
    public class PersonRepository
    {
        private readonly ComposeContext _context;

        public PersonRepository(ComposeContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetPersons()
        {
            return _context.Persons.ToList();
        }

        public void AddPerson(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
        }
    }
}
