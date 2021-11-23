using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDialogo : MonoBehaviour
{
    public Personajes personaje;
    public Personajes jugador;
    public TextMeshProUGUI texto;
    int i;
    public int indicadorScene;
    public int personajeActual = 0;
   
    public void sig()
    {
        if (personaje.dialogo.Length > i)
        {
            if (personajeActual == 0)
            {
                texto.text = personaje.dialogo[i];
                personajeActual = 1;
            }
            else
            {
                if (indicadorScene == 4)
                {
                    texto.text = jugador.dialogo[i];
                    //Debug.Log(jugador.dialogo[i]);
                    i++;
                    personajeActual = 0;
                } else
                {
                    texto.text = jugador.dialogo2[i];
                    //Debug.Log(jugador.dialogo[i]);
                    i++;
                    personajeActual = 0;

                }
            }
        } else
        {
                PlayerPrefs.SetInt("PUNTAJE", PlayerPrefs.GetInt("PUNTAJE") + 10);
                SceneManager.LoadScene(indicadorScene++);

            } 
        }
    }


