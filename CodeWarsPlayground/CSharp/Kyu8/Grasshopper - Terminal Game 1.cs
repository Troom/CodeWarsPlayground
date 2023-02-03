namespace CodeWarsPlayground.CSharp.Kyu8
{
    internal class Grasshopper___Terminal_Game_1
    {
        public class Hero
        {
            public string Name { get; set; }
            public string Position { get; set; } = "00";
            public float Health { get; set; } = 100;
            public float Damage { get; set; } = 5;
            public int Experience { get; set; } = 0;

            public Hero(string name = "Hero")
            {
                this.Name = name;
            }
        }
    }
}
