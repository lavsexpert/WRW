namespace Game.Data
{
    public class Product
    {
        public string name = "Item";
        public string image = "icon";
        public float price = 0.00f;
        public int shelflife = 0;

        public float money = 0.00f;
        public float mood = 0.00f;
        public float attention = 0.00f;
        public float mind = 0.00f;
        public float sociability = 0.00f;
        public float mystic = 0.00f;
    
        private float delta_money = 0.0f;
        private float delta_mood = 0.0f;
        private float delta_attention = 0.0f;
        private float delta_mind = 0.0f;
        private float delta_sociability = 0.0f;
        private float delta_mystic = 0.0f;

        public Product(string name, string image, float price, int shelflife)
        {
            this.name = name;
            this.image = image;
            this.price = price;
            this.shelflife = shelflife;
        }

        public void NextDay()
        {
            shelflife--;
        }

        public void SetMoney(float money, float delta_money)
        {
            this.money = money;
            this.delta_money = delta_money;
        }

        public void SetMood(float mood, float delta_mood)
        {
            this.mood = mood;
            this.delta_mood = delta_mood;
        }

        public void SetAttention(float attention, float delta_attention)
        {
            this.attention = attention;
            this.delta_attention = delta_attention;
        }

        public void SetMind(float mind, float delta_mind)
        {
            this.mind = mind;
            this.delta_mind = delta_mind;
        }

        public void SetSociability(float sociability, float delta_sociability)
        {
            this.sociability = sociability;
            this.delta_sociability = delta_sociability;
        }

        public void SetMystic(float mystic, float delta_mystic)
        {
            this.mystic = mystic;
            this.delta_mystic = delta_mystic;
        }
    }
}