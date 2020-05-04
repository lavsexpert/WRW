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
        public Image panel;
        public Button menuButton;

        public Sprite sprite;
        public Sprite bankrupt;
        public Sprite coma;
        public Sprite disabled;
        public Sprite goblin;
        public Sprite hermit;
        public Sprite madness;
        public Sprite slavery;
        public Sprite suicide;
        public Sprite zombie;

        void Start()
        {
            Debug.Log("Lose.OnStart()");
            core = Core.getInstance();
            text.text = core.user.losetext;
             panel.sprite = SetImage(core.user.loseimage);
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

        public Sprite SetImage(string image)
        {
            switch (image)
            {
                case "bankrupt":
                    return bankrupt;
                case "coma":
                    return coma;
                case "disabled":
                    return disabled;
                case "goblin":
                    return goblin;
                case "hermit":
                    return hermit;
                case "madness":
                    return madness;
                case "slavery":
                    return slavery;
                case "suicide":
                    return suicide;
                case "zombie":
                    return zombie;
                default:
                    return sprite;
            }
        }
    }
}
