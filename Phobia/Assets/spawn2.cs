using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn2 : MonoBehaviour
{
    public GameObject Foodprefab;
    public Rigidbody rigidbody;
    public Vector3 center;
    public Vector3 size;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            SpawnSpiders();
    }
    public void SpawnSpiders()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        var sp = Instantiate(Foodprefab, pos, Quaternion.identity) as GameObject;
        sp.AddComponent<move1>();
        sp.AddComponent<Rigidbody>();
        sp.AddComponent<BoxCollider>();
        sp.AddComponent<notCrossing>();
        rigidbody = sp.GetComponent<Rigidbody>();
        rigidbody.useGravity = false;

        sp.transform.Rotate(0, Random.Range(0, 360), 0, Space.World);
        sp.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);


    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
