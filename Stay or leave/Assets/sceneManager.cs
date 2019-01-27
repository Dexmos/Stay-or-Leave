using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sceneManager : MonoBehaviour
{
    public GameObject player;
    public GameObject SpawnPoint;


    private void Start()
    {
        if (PlayerPrefs.GetInt("spawn", 1) == 1)
        {
            player.GetComponent<Transform>().position = SpawnPoint.GetComponent<Transform>().position;
            player.GetComponent<Transform>().rotation = SpawnPoint.GetComponent<Transform>().rotation;
            PlayerPrefs.SetInt("spawn", 0);
        }
    }
}
