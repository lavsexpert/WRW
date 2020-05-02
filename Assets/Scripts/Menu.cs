using Game.Core;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scripts.Scenes
{
    public class Menu : MonoBehaviour
    {
        private Core core;
        public Button startButton, restoreButton, exitButton;

        void Start()
        {
            Debug.Log("Menu.OnStart()");
            startButton.onClick.AddListener(StartPressed);
            restoreButton.onClick.AddListener(RestorePressed);
            exitButton.onClick.AddListener(ExitPressed);
        }

        public void StartPressed()
        {
            Debug.Log("Menu.StartPressed()");
            core = Core.getInstance();
            if (core.user.hour < 8)
            {
                SceneManager.LoadScene("Dream");
            }
            else if (core.user.hour < 16)
            {
                SceneManager.LoadScene("Work");
            }
            else
            {
                SceneManager.LoadScene("Rest");
            }

        }

        public void RestorePressed()
        {
            Debug.Log("Menu.RestorePressed()");
        }

        public void ExitPressed()
        {
            Debug.Log("Menu.ExitPressed()");
            Application.Quit();
        }

        public void Destroy()
        {
            Debug.Log("Menu.Destroy()");
            startButton.onClick.RemoveListener(StartPressed);
            restoreButton.onClick.RemoveListener(RestorePressed);
            exitButton.onClick.RemoveListener(ExitPressed);
        }
    }
}
