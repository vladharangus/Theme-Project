using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    int speed = 30;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.Translate(new Vector3(-5*speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.Translate(new Vector3(5*speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            transform.Translate(new Vector3(0, 0,5*speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            
            transform.Translate(new Vector3(0, 0, -5*speed * Time.deltaTime));

        }
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(-Vector3.up * speed *5 *  Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up * speed  *5* Time.deltaTime);
    }
}
