using Game.Core;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scripts.Scenes
{
    public class Work : MonoBehaviour
    {
        private Core core;
        public Text textMoney, textMood, textAttention, textMind, textSociability, textMystic, textTime, textDate, textWeekDay;
        public Button dreamButton, workButton, restButton, shopButton, menuButton;

        void Start()
        {
            Debug.Log("Work.OnStart()");
            core = Core.getInstance();
            dreamButton.onClick.AddListener(DreamPressed);
            workButton.onClick.AddListener(WorkPressed);
            restButton.onClick.AddListener(RestPressed);
            shopButton.onClick.AddListener(ShopPressed);
            menuButton.onClick.AddListener(MenuPressed);
            SetText();
        }

        public void DreamPressed()
        {
            Debug.Log("Work.DreamPressed()");
            core.user.Dream();
            SetText();
            if (core.user.gameover)
            {
                SceneManager.LoadScene("Lose");
            }
            else
            {
                SceneManager.LoadScene("Dream");
            }
        }

        public void WorkPressed()
        {
            Debug.Log("Work.WorkPressed()");
            core.user.Work();
            SetText();
            if (core.user.gameover)
            {
                SceneManager.LoadScene("Lose");
            }
        }

        public void RestPressed()
        {
            Debug.Log("Work.RestPressed()");
            core.user.Rest();
            SetText();
            if (core.user.gameover)
            {
                SceneManager.LoadScene("Lose");
            }
            else
            {
                SceneManager.LoadScene("Rest");
            }
        }

        public void ShopPressed()
        {
            Debug.Log("Work.ShopPressed()");
            SceneManager.LoadScene("Shop");
        }

        public void MenuPressed()
        {
            Debug.Log("Work.MenuPressed()");
            SceneManager.LoadScene("Menu");
        }

        public void Destroy()
        {
            Debug.Log("Work.Destroy()");
            dreamButton.onClick.RemoveListener(DreamPressed);
            workButton.onClick.RemoveListener(WorkPressed);
            restButton.onClick.RemoveListener(RestPressed);
            shopButton.onClick.RemoveListener(ShopPressed);
            menuButton.onClick.RemoveListener(MenuPressed);
        }

        private void SetText()
        {
            textMoney.text = core.user.money.ToString();
            textMood.text = core.user.mood.ToString();
            textAttention.text = core.user.attention.ToString();
            textMind.text = core.user.mind.ToString();
            textSociability.text = core.user.sociability.ToString();
            textMystic.text = core.user.mystic.ToString();
            textTime.text = core.user.hour.ToString() + ":00";
            textDate.text = "День " + core.user.day.ToString();
            textWeekDay.text = core.user.GetWeekDay();
        }
    }
}
