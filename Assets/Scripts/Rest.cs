using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rest : MonoBehaviour
{
    public Button dreamButton, workButton, shopButton, menuButton;

    void Start()
    {
        Debug.Log("Rest.OnStart()");
        dreamButton.onClick.AddListener(DreamPressed);
        workButton.onClick.AddListener(WorkPressed);
        shopButton.onClick.AddListener(ShopPressed);
        menuButton.onClick.AddListener(MenuPressed);
    }

    public void DreamPressed()
    {
        Debug.Log("Rest.DreamPressed()");
        SceneManager.LoadScene("Dream");
    }

    public void WorkPressed()
    {
        Debug.Log("Rest.WorkPressed()");
        SceneManager.LoadScene("Work");
    }

    public void ShopPressed()
    {
        Debug.Log("Rest.ShopPressed()");
        SceneManager.LoadScene("Shop");
    }

    public void MenuPressed()
    {
        Debug.Log("Rest.MenuPressed()");
        SceneManager.LoadScene("Menu");
    }

    public void Destroy()
    {
        Debug.Log("Rest.Destroy()");
        dreamButton.onClick.RemoveListener(DreamPressed);
        workButton.onClick.RemoveListener(WorkPressed);
        shopButton.onClick.RemoveListener(ShopPressed);
        menuButton.onClick.RemoveListener(MenuPressed);
    }
}
