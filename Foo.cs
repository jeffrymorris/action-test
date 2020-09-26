using System;
using System.Collections.Generic;
using System.Text;

namespace Couchbase
{
    public class Foo
    {
        public string Bar { get; set; }

        public int Vaz { get; set; }

        public override string ToString()
        {
            return Bar ?? "Hello, world.";
        }
    }
}
