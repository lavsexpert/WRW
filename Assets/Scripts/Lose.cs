using Game.Core;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scripts.Scenes
{
    public class Lose : MonoBehaviour
    {
        private Core core;
        public Text text;
        public Button menuButton;

        void Start()
        {
            Debug.Log("Lose.OnStart()");
            core = Core.getInstance();
            text.text = core.user.losetext;
            menuButton.onClick.AddListener(MenuPressed);
        }

        public void MenuPressed()
        {
            Debug.Log("Lose.MenuPressed()");
            core.user.Reset();
            SceneManager.LoadScene("Menu");
        }

        public void Destroy()
        {
            Debug.Log("Lose.Destroy()");
            menuButton.onClick.RemoveListener(MenuPressed);
        }
    }
}
