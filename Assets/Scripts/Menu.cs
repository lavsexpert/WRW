using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
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
        SceneManager.LoadScene("Dream");
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
