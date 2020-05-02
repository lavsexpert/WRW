using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Work : MonoBehaviour
{
    public Button restButton, dreamButton, shopButton, menuButton;

    void Start()
    {
        Debug.Log("Work.OnStart()");
        restButton.onClick.AddListener(RestPressed);
        dreamButton.onClick.AddListener(DreamPressed);
        shopButton.onClick.AddListener(ShopPressed);
        menuButton.onClick.AddListener(MenuPressed);
    }

    public void RestPressed()
    {
        Debug.Log("Work.RestPressed()");
        SceneManager.LoadScene("Rest");
    }

    public void DreamPressed()
    {
        Debug.Log("Work.DreamPressed()");
        SceneManager.LoadScene("Dream");
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
        restButton.onClick.RemoveListener(RestPressed);
        dreamButton.onClick.RemoveListener(DreamPressed);
        shopButton.onClick.RemoveListener(ShopPressed);
        menuButton.onClick.RemoveListener(MenuPressed);
    }
}
