using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rb;
    [SerializeField]float timetowait = 3f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timetowait)
        {
            renderer.enabled = true;
            rb.useGravity = true;  }
    }
}
