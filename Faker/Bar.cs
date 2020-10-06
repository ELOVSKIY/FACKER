namespace Faker
{
    [Dto]
    public class Bar
    {
        public int x;
        public Foo foo;
        public string name;
        public string group;
        public int mark;

        public Bar(Foo foo)
        {
            this.foo = foo;
        }

        public override string ToString()
        {
            return
                "\nfoo: " + foo.ToString() +
                "\nx: " + x.ToString() +
                "\nname: " + name +
                "\ngroup: " + group +
                "\nmark: " + mark;
        }
    }
    
}