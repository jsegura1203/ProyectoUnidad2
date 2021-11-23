using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    public GameObject area;
    public GameObject flecha_;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject flecha = Instantiate(flecha_, area.transform.position,
                area.transform.rotation) as GameObject;
            Destroy(flecha, 1);
        }
    }
}
