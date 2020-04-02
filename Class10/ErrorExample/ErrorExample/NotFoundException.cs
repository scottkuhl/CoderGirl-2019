using System;

namespace ErrorExample
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException() : base("We could not find what you were looking for.")
        {
        }
    }
}
