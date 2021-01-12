using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    int speed = 30;
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            source.Play();
            transform.Translate(new Vector3(-3*speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            source.Play();
            transform.Translate(new Vector3(3*speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            source.Play();
            transform.Translate(new Vector3(0, 0,3*speed * Time.deltaTime));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            source.Play();
            transform.Translate(new Vector3(0, 0, -3*speed * Time.deltaTime));

        }
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(-Vector3.up * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
