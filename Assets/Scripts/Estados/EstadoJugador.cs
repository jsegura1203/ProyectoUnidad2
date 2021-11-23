using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EstadoJugador : MonoBehaviour
{
    IEnumerator pantallaFinal()
    {
        yield return new WaitForSeconds(1);
        PlayerPrefs.SetString("PERDEDOR", "Ada White");
        PlayerPrefs.SetInt("PUNTAJE", 0);
        SceneManager.LoadScene(8);
    }


    private void OnCollisionEnter(Collision collision)
    {
        string flecha = collision.gameObject.tag;
        if (flecha.Equals("flecha"))
        {
            StartCoroutine(pantallaFinal());
        }
    }
}
