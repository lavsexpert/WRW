using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Button dreamButton, workButton, restButton, menuButton;

    void Start()
    {
        Debug.Log("Shop.OnStart()");
        dreamButton.onClick.AddListener(DreamPressed);
        workButton.onClick.AddListener(WorkPressed);
        restButton.onClick.AddListener(RestPressed);
        menuButton.onClick.AddListener(MenuPressed);
    }

    public void DreamPressed()
    {
        Debug.Log("Shop.DreamPressed()");
        SceneManager.LoadScene("Dream");
    }

    public void WorkPressed()
    {
        Debug.Log("Shop.WorkPressed()");
        SceneManager.LoadScene("Work");
    }

    public void RestPressed()
    {
        Debug.Log("Shop.RestPressed()");
        SceneManager.LoadScene("Rest");
    }


    public void MenuPressed()
    {
        Debug.Log("Shop.MenuPressed()");
        SceneManager.LoadScene("Menu");
    }

    public void Destroy()
    {
        Debug.Log("Shop.Destroy()");
        dreamButton.onClick.RemoveListener(DreamPressed);
        workButton.onClick.RemoveListener(WorkPressed);
        restButton.onClick.RemoveListener(RestPressed);
        menuButton.onClick.RemoveListener(MenuPressed);
    }
}
