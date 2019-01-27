using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    public float wait = 5;

    void Start()
    {
        StartCoroutine(WaitAndPrint(wait));
    }

    private IEnumerator WaitAndPrint(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(0);
    }
}
