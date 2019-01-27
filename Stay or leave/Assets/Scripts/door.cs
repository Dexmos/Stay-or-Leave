using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && (PlayerPrefs.GetInt("canEnter") == 1))
        {
            SceneManager.LoadScene("principal_house");
        }
    }
}
