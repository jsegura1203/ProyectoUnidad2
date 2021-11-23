using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smooth_LookAt : MonoBehaviour
{
    public GameObject jugador;
    public GameObject [] personajes;
    public GameObject canvaDialogo;
    
    private void OnTriggerStay(Collider other)
    {
        jugador.GetComponent<Mov_Camara>().enabled = false;
        Vector3 posicion = jugador.transform.position;
        for (int i = 0; i < personajes.Length; i++)
            personajes[i].transform.LookAt(posicion);
        dialogos();
    }

    void dialogos()
    {
        canvaDialogo.SetActive(true);
    }

}
