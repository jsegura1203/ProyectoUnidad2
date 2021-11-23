using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Final : MonoBehaviour
{
    public TextMeshProUGUI titulo;
    public TextMeshProUGUI texto;
    public TextMeshProUGUI puntaje;
    void Start()
    {
        generarTitulo();
    }

    void generarTitulo()
    {
        string perdedor = PlayerPrefs.GetString("PERDEDOR");
        if (perdedor.Equals("Draver"))
        {
            titulo.text = "HAZ GANADO!!!";
            texto.text = "Ada vencío limpiamente a Draver, aunque con algunas heridas leves," +
                " y le pudo regresar lo robado al pueblo, " +
                "agradecido el pueblo la convirtio en un personaje historico de la era medieval.";
            puntaje.text = "Puntaje final: " + PlayerPrefs.GetInt("PUNTAJE");
        } else
        {
            titulo.text = "Haz perdido.";
            texto.text = "Ada fallecio en el duelo contra Draver. Ada fue recordada cómo un icono de" +
                " bondad, aunque Draver con su riqueza, logro que eso se perdiera en los proximos 20 años.";
            puntaje.text = "Puntaje final: " + PlayerPrefs.GetInt("PUNTAJE");
        }
        PlayerPrefs.DeleteAll();
    }

}
