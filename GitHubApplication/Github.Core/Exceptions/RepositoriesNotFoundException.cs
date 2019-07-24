using System;
using System.Collections.Generic;
using System.Text;

namespace Github.Core.Exceptions
{
    public class RepositoriesNotFoundException : Exception
    {
        public RepositoriesNotFoundException(string message) : base(message)
        {
        }

        public RepositoriesNotFoundException() : base()
        {
        }
    }
}
