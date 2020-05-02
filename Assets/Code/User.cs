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
        public string losetext = "";            // Текст проигрыша

        private float delta_money = 10.0f;
        private float delta_mood = 10.0f;
        private float delta_attention = 10.0f;
        private float delta_mind = 10.0f;
        private float delta_sociability = 10.0f;
        private float delta_mystic = 10.0f;

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
            losetext = "";
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
            mood += delta_mood;
            mystic += delta_mystic;
            mind -= delta_mind;
            sociability -= delta_sociability;
            AddHour();
            if (mind <= 0 || sociability <= 0)
            {
                gameover = true;
                if (mind <= 0 && sociability <= 0)
                {
                    losetext = name + " убежал в лес и там сошёл с ума, став лешим.";
                } else if (mind <= 0)
                {
                    losetext = name + " начал кидаться на людей и его увезли в психушку.";
                } else if (sociability <= 0)
                {
                    losetext = name + " подстригся в монахи и ушёл в монастырь.";
                }
            }
        }

        // Поработать
        public void Work()
        {
            money += delta_money;
            mind += delta_mind;
            mood -= delta_mood;
            attention -= delta_attention;
            AddHour();
            if (mood <= 0 || attention <= 0)
            {
                gameover = true;
                if (mood <= 0 && attention <= 0)
                {
                    losetext = name + " после неудачной попытки самоубийства стал инвалидом.";
                }
                else if (mood <= 0)
                {
                    losetext = name + " спрыгнул с крыши небоскрёба.";
                }
                else if (attention <= 0)
                {
                    losetext = name + " попал под машину и теперь лежит в коме.";
                }
            }
        }

        // Отдохнуть
        public void Rest()
        {
            attention += delta_attention;
            sociability += delta_sociability;
            money -= delta_money;
            mystic -= delta_mystic;
            AddHour();
            if (money <= 0 || mystic <= 0)
            {
                gameover = true;
                if (money <= 0 && mystic <= 0)
                {
                    losetext = name + " был похищен и попал в рабство.";
                }
                else if (money <= 0)
                {
                    losetext = name + " набрал кредитов и теперь банкрот.";
                }
                else if (mystic <= 0)
                {
                    losetext = name + " стал зомби после шаманского ритуала.";
                }
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