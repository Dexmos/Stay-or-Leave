using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pnj : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    public GameObject _pnj2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("spik", 1);
            panel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        panel.SetActive(false);
        _pnj2.SetActive(false);
        panel2.SetActive(true);
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
        panel2.SetActive(false);
        GetComponent<BoxCollider>().enabled = false;
    }
}
