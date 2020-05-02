using Game.Core;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scripts.Scenes
{
    public class Work : MonoBehaviour
    {
        private Core core;
        public Text text;
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
            text.text = core.user.ToString;
        }

        public void DreamPressed()
        {
            Debug.Log("Work.DreamPressed()");
            core.user.Dream();
            text.text = core.user.ToString;
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
            text.text = core.user.ToString;
            if (core.user.gameover)
            {
                SceneManager.LoadScene("Lose");
            }
        }

        public void RestPressed()
        {
            Debug.Log("Work.RestPressed()");
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
    }
}
