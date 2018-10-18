namespace ConsoleApplication {
    public class Human {
        public string name = { get; set; }
        public int strength = { get; set; }
        public int intelligence = { get; set; }
        public int dextrexity = { get; set; }
        public int health = { get; set; }
        public int damage = { get; set; }

        public Human(string firstname, int val) {
            name = firstname;
            strength = val;
            intelligence = val;
            dextrexity = val;
            health = val;
            damage = strength*5;
        }

        public void attack(int punch) {}
    }
}