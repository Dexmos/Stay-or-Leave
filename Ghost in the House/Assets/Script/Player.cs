using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text countCoin;

    public Text finalText;
    private Rigidbody rb;
    private int nb_destroy;
    private int nb_coins;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        nb_destroy = 0;
        nb_coins = 0;
        countText.text = "Task: " + nb_destroy.ToString () + "/4";
        countCoin.text = "Coins: " + nb_coins.ToString();

    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            nb_destroy += 1;
            nb_coins += 100;
            SetCountText();
        }
        if (other.gameObject.CompareTag("money"))
        {
            other.gameObject.SetActive(false);
            nb_coins += 1000;
            SetCountText();
        }
    }
    void SetCountText ()
    {
        countText.text = "Task: " + nb_destroy.ToString() + "/4";
        countCoin.text = "Coins: " + nb_coins.ToString();
    }


}
