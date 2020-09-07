using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float speed = 10f;
    public KeyCode moveUp;
    public KeyCode movedown;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveUp))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f,speed);
        }
        else if (Input.GetKey(movedown))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, speed * -1);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }
    }
}
