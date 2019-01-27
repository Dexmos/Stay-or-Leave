using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forge : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && (PlayerPrefs.GetInt("spik") == 0))
        {
            panel3.SetActive(true);
        }
        if (other.CompareTag("Player") && (PlayerPrefs.GetInt("spik") == 1))
        { 
            if ((PlayerPrefs.GetInt("canPurchase") == 0))
            {
                score.SetActive(true);
                panel.SetActive(true);
            }
            else if ((PlayerPrefs.GetInt("canPurchase") == 1))
            {
                panel2.SetActive(true);
                score.SetActive(false);
                PlayerPrefs.SetInt("canEnter", 1);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        panel.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        score.SetActive(true);
    }
}
