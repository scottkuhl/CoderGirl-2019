using System;

namespace Prep4
{
    public class AbstractEntity
    {


        //private static int nextId = 1;

        public Guid Id { get; private set; } = Guid.NewGuid();

        //public AbstractEntity()
        //{
        //    Id = nextId++;
        //}
    }
}
