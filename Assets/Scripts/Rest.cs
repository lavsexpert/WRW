using Game.Core;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scripts.Scenes
{
    public class Rest : MonoBehaviour
    {
        private Core core;
        public Text textMoney, textMood, textAttention, textMind, textSociability, textMystic;
        public Button dreamButton, workButton, restButton, shopButton, menuButton;

        void Start()
        {
            Debug.Log("Rest.OnStart()");
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
            Debug.Log("Rest.DreamPressed()");
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
            Debug.Log("Rest.WorkPressed()");
            core.user.Work();
            SetText();
            if (core.user.gameover)
            {
                SceneManager.LoadScene("Lose");
            }
            else
            {
                SceneManager.LoadScene("Work");
            }
        }

        public void RestPressed()
        {
            Debug.Log("Rest.RestPressed()");
            core.user.Rest();
            SetText();
            if (core.user.gameover)
            {
                SceneManager.LoadScene("Lose");
            }
        }

        public void ShopPressed()
        {
            Debug.Log("Rest.ShopPressed()");
            SceneManager.LoadScene("Shop");
        }

        public void MenuPressed()
        {
            Debug.Log("Rest.MenuPressed()");
            SceneManager.LoadScene("Menu");
        }

        public void Destroy()
        {
            Debug.Log("Rest.Destroy()");
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
        }
    }
}
