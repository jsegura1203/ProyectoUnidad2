using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EstadoEnemigo : MonoBehaviour
{
    AtaqueEnemigo enemigo;
    void Start()
    {
        enemigo = GetComponent<AtaqueEnemigo>();
    }
    IEnumerator pantallaFinal()
    {
        yield return new WaitForSeconds(1);
        PlayerPrefs.SetString("PERDEDOR", "Draver");
        PlayerPrefs.SetInt("PUNTAJE", PlayerPrefs.GetInt("PUNTAJE") * 2);
        SceneManager.LoadScene(8);
    }


    private void OnCollisionEnter(Collision collision)
    {
        string flecha = collision.gameObject.tag;
        if (flecha.Equals("flecha"))
        {
            enemigo.vivo = false;
            StartCoroutine(pantallaFinal());
        }
    }
}
