namespace Faker
{
    [Dto]
    public class Bar
    {
        public int x;
        public Foo foo;

        public Bar(Foo foo)
        {
            this.foo = foo;
        }
    }
}