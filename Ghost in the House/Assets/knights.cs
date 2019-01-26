using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knights : MonoBehaviour
{
    private Rigidbody rigidB;
    // public int speed = 0;
    public int Score;
    public int rand = 0;
    public int droite = 0;
    public int gauche = 0;
    public int rotatl = 0;
    public int rotatd = 0;

    void Start()
    {
        rigidB = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name != "sol")
        {
            transform.Rotate(0, 180, 0);
            transform.Translate(0, 0, 3 * Time.deltaTime, Space.Self);
        }
    }

    void FixedUpdate()
    {
        // transform.Translate(0, 0, speed * Time.deltaTime, Space.Self);
        rand = Random.Range(0, 3000);
        transform.Translate(0, 0, 3 * Time.deltaTime, Space.Self);

        if (rand == 666 || rotatd > 0)
        {
            transform.Rotate(0, -1, 0);
            rotatd++;
            if (rotatd > 40)
                rotatd = 0;
        }
        else if (rand == 212 || rotatl > 0)
        {
            transform.Rotate(0, 1, 0);
            rotatl++;
            if (rotatl > 40)
                rotatl = 0;
        }
    }
}