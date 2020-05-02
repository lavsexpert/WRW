using System;

namespace Game.Data
{
    public class User
    {
        public string name = "Noob";            // Имя

        public DateTime date = DateTime.Today;  // Дата в игре             
        public int weekday = 0;                 // Текущий день недели игры
        public int day = 0;                     // Текущий день игры
        public int hour = 0;                    // Текущий час игры с полуночи

        public float money = 100.00f;           // Деньги
        public float mood = 100.00f;            // Настроение
        public float attention = 100.00f;       // Внимание
        public float mind = 100.00f;            // Ум
        public float sociability = 100.00f;     // Общительность
        public float mystic = 100.00f;          // Мистика
        public bool gameover = false;           // Игра закончена

        // Установка времени и даты в игре
        public void SetTime()
        {
            day = 1;
            weekday = ((int)date.DayOfWeek + 6) % 7 + 1;    // Получение дня недели: 1 - пн, 2 - вт, ..., 7 - вс
            hour = date.Hour;
        }

        // Обнуление пользователя (например, при старте новой игры)
        public void Reset()
        {
            money = 100.00f;
            mood = 100.00f;
            attention = 100.00f;
            mind = 100.00f;
            sociability = 100.00f;
            mystic = 100.00f;
            gameover = false;
            SetTime();
        }

        // Добавить час - сделать ход
        public void AddHour()
        {
            hour = hour + 1;
            if (hour > 23)
            {
                day = day + 1;
                weekday = weekday + 1;
                if (weekday > 7)
                {
                    weekday = 1;
                }
            }
        }

        // Поспать
        public void Dream()
        {
            mood++;
            mystic++;
            mind--;
            sociability--;
            AddHour();
            if (mind <= 0 || sociability <= 0)
            {
                gameover = true;
            }
        }

        // Поработать
        public void Work()
        {
            money++;
            mind++;
            mood--;
            attention--;
            AddHour();
            if (mood <= 0 || attention <= 0)
            {
                gameover = true;
            }
        }

        // Отдохнуть
        public void Rest()
        {
            attention++;
            sociability++;
            money--;
            mystic--;
            AddHour();
            if (money <= 0 || mystic <= 0)
            {
                gameover = true;
            }
        }

        public new string ToString
        {
            get
            {
                string text = "";
                text += money.ToString()        + "\t деньги\n";
                text += mood.ToString()         + "\t настроение\n";
                text += attention.ToString()    + "\t внимание\n";
                text += mind.ToString()         + "\t ум\n";
                text += sociability.ToString()  + "\t общение\n";
                text += mystic.ToString()       + "\t мистика";
                return text;
            }
        }
    }
}