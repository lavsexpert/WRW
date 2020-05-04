using Game.Data;
using System.Collections.Generic;

namespace Game.Core
{
    public class Core
    {
        private static Core instance;

        public User user;
        public List<Product> shop = new List<Product>();

        // Главная функция
        public static void Main()
        {
            getInstance();
        }

        // Получение объекта-одиночки
        public static Core getInstance()
        {
            if (instance == null)
                instance = new Core();
            return instance;
        }

        // Конструктор
        private Core()
        {
            user = new User();
            user.SetTime();
        }
    }
}