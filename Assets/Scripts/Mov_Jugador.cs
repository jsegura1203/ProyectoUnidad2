using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Jugador : MonoBehaviour
{
    [SerializeField]
    public float speed = 4.0f; //Velocidad de movimiento
    public float rotationSpeed = 100.0F; //Velocidad de rotación
    public Animator animator;

    private float x, y;

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Translate(0, 0, y * speed * Time.deltaTime);
        transform.Rotate(0, x * rotationSpeed * Time.deltaTime, 0);
        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);
    }
}

