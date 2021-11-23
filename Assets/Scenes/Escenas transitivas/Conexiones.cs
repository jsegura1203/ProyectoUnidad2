using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Conexiones : MonoBehaviour
{
    public int escena_siguiente;
    public void abrirEscena()
    {
        SceneManager.LoadScene(escena_siguiente);
    }
}
