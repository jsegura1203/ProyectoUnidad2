using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Flecha : MonoBehaviour
{
    Rigidbody rb;

    public float velocidadMov;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        rb.AddForce(Vector3.left * velocidadMov, ForceMode.Impulse);
    }
}
