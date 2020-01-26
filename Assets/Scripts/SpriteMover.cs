using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    private Transform tf;

    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            //Only works if shift is held down.

            //Changes color when pressing shift
            GetComponent<SpriteRenderer>().color = Color.red;

        }
        else
        {
            //Only works if shift is not held down.

            // Movement for going up
            if (Input.GetKey(KeyCode.UpArrow))
            {
                tf.position = tf.position + (Vector3.up * Time.deltaTime * speed);
                //Changes to green when going up
                GetComponent<SpriteRenderer>().color = Color.green;
            }
            //Movement for going left
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                tf.position = tf.position + (Vector3.left * Time.deltaTime * speed);
                //Changes to blue when going left
                GetComponent<SpriteRenderer>().color = Color.blue;
            }
            //Movement for going down
            if (Input.GetKey(KeyCode.DownArrow))
            {
                tf.position = tf.position + (Vector3.down * Time.deltaTime * speed);
                //Changes to yellow when going down
                GetComponent<SpriteRenderer>().color = Color.yellow;
            }
            //Movement for going right
            if (Input.GetKey(KeyCode.RightArrow))
            {
                tf.position = tf.position + (Vector3.right * Time.deltaTime * speed);
                //Changes to cyan when going right
                GetComponent<SpriteRenderer>().color = Color.cyan;
            }

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tf.position = new Vector3(0, 0, 0);
        }
    }
}
