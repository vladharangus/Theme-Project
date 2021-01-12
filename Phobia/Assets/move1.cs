using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1: MonoBehaviour
{

    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
       source =  GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        source.Play();
        transform.Translate(Vector3.forward * Time.deltaTime * 5);
    }
    
}
