using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collect_gems : MonoBehaviour
{
    public GameObject[] gems;
    public Text score;

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("gem"))
        {
            PlayerPrefs.SetInt("gem", PlayerPrefs.GetInt("gem") + 1);
            Debug.Log("Gem: " + PlayerPrefs.GetInt("gem"));
            score.text = PlayerPrefs.GetInt("gem") + " / 7";
            Destroy(other.gameObject);
            if (PlayerPrefs.GetInt("gem") >= 7)
                PlayerPrefs.SetInt("canPurchase", 1);
        }
    }
}
