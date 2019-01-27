using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void play()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("canPurchase", 0);
        PlayerPrefs.SetInt("canEnter", 0);
        PlayerPrefs.SetInt("gem", 0);
        PlayerPrefs.SetInt("spik", 0);
        SceneManager.LoadScene(2);
    }

    public void credits()
    {
        SceneManager.LoadScene(1);
    }

    public void quit()
    {
        Application.Quit();
    }
}
