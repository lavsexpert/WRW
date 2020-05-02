using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dream : MonoBehaviour
{
    public Button workButton, restButton, shopButton, menuButton;

    void Start()
    {
        Debug.Log("Dream.OnStart()");
        workButton.onClick.AddListener(WorkPressed);
        restButton.onClick.AddListener(RestPressed);
        shopButton.onClick.AddListener(ShopPressed);
        menuButton.onClick.AddListener(MenuPressed);
    }

    public void WorkPressed()
    {
        Debug.Log("Dream.WorkPressed()");
        SceneManager.LoadScene("Work");
    }

    public void RestPressed()
    {
        Debug.Log("Dream.RestPressed()");
        SceneManager.LoadScene("Rest");
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
        workButton.onClick.RemoveListener(WorkPressed);
        restButton.onClick.RemoveListener(RestPressed);
        shopButton.onClick.RemoveListener(ShopPressed);
        menuButton.onClick.RemoveListener(MenuPressed);
    }
}
