using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CargaInfo : MonoBehaviour
{
    int puntos;
    public TextMeshProUGUI puntaje;
    // Start is called before the first frame update
    void Start()
    {
        puntos = PlayerPrefs.GetInt("PUNTAJE", 0);
        puntaje.text = "Puntaje: " + puntos;
        Debug.Log(puntos);
    }

}
