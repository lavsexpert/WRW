using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button startButton, restoreButton, exitButton;

    void Start()
    {
        Debug.Log("OnStart()");
        startButton.onClick.AddListener(() => StartPressed());
        restoreButton.onClick.AddListener(() => RestorePressed());
        exitButton.onClick.AddListener(() => ExitPressed());
    }

    public void StartPressed()
    {
        SceneManager.LoadScene("Profile");
        Debug.Log("StartPressed()");
    }

    public void RestorePressed()
    {
        Debug.Log("RestorePressed()");
    }

    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("ExitPressed()");
    }

    public void Destroy()
    {
        startButton.onClick.RemoveListener(() => StartPressed());
        restoreButton.onClick.RemoveListener(() => RestorePressed());
        exitButton.onClick.RemoveListener(() => ExitPressed());
    }
}
