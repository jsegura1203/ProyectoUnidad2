using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transcision_Escenas : MonoBehaviour
{
    public int scene;
    private void OnTriggerEnter(Collider other)
    {
        int valor = PlayerPrefs.GetInt("PUNTAJE", 0);
        PlayerPrefs.SetInt("PUNTAJE", valor + 10);
        SceneManager.LoadScene(scene);
    }
}
