using System;
using System.Collections.Generic;

namespace Faker
{
    [Dto]
    public class Foo
    {
        public int x;
        public string y;
        // public List<Bar> z;
        public Bar z;
        public DateTime Num { get; set; }

        public Foo(int x, DateTime num)
        {
            this.x = x;
            Num = num;
        }

        private Foo(DateTime num)
        {
            Num = num;
            x = 1;
            y = "1";
        }
    }
}