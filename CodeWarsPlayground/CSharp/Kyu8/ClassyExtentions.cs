namespace CodeWarsPlayground.CSharp.Kyu8
{
    internal class ClassyExtentions
    {

        public class Cat : Animal
        {
            private string _name;
            public Cat(string name) : base(name)
            {
                _name = name;
            }
            public override string Speak()
            {
                return $"{_name} meows.";
            }
        }

        public class Animal {

            public Animal(string name) { 
            }
            public virtual string Speak() {
                return "";
            }
        }

    }
}
