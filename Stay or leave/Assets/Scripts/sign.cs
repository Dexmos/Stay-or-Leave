using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sign : MonoBehaviour
{
    public GameObject panel;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            panel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        panel.SetActive(false);
    }
}
