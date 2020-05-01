using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void StartPressed()
    {
        SceneManager.LoadScene("Profile");
        Debug.Log("Start pressed!");
    }

    public void RestorePressed()
    {
        Debug.Log("Restore pressed!");
    }

    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
}
