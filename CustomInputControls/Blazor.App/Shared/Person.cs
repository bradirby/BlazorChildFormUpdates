using System;

namespace Blazor.App.Shared
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class GuidPerson
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class IntPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }

}
