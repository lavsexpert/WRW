using Game.Core;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scripts.Scenes
{
    public class Dream : MonoBehaviour
    {
        private Core core;
        public Text text;
        public Button dreamButton, workButton, restButton, shopButton, menuButton;

        void Start()
        {
            Debug.Log("Dream.OnStart()");
            core = Core.getInstance();
            dreamButton.onClick.AddListener(DreamPressed);
            workButton.onClick.AddListener(WorkPressed);
            restButton.onClick.AddListener(RestPressed);
            shopButton.onClick.AddListener(ShopPressed);
            menuButton.onClick.AddListener(MenuPressed);
            text.text = core.user.ToString;
        }

        public void DreamPressed()
        {
            Debug.Log("Dream.DreamPressed()");
            core.user.Dream();
            text.text = core.user.ToString;
            if (core.user.gameover)
            {
                SceneManager.LoadScene("Lose");
            }
        }

        public void WorkPressed()
        {
            Debug.Log("Dream.WorkPressed()");
            core.user.Work();
            text.text = core.user.ToString;
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
            Debug.Log("Dream.RestPressed()");
            core.user.Rest();
            text.text = core.user.ToString;
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
            Debug.Log("Dream.ShopPressed()");
            SceneManager.LoadScene("Shop");
        }

        public void MenuPressed()
        {
            Debug.Log("Dream.MenuPressed()");
            SceneManager.LoadScene("Menu");
        }

        public void Destroy()
        {
            Debug.Log("Dream.Destroy()");
            dreamButton.onClick.RemoveListener(DreamPressed);
            workButton.onClick.RemoveListener(WorkPressed);
            restButton.onClick.RemoveListener(RestPressed);
            shopButton.onClick.RemoveListener(ShopPressed);
            menuButton.onClick.RemoveListener(MenuPressed);
        }
    }
}
