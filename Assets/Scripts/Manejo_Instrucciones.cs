using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manejo_Instrucciones : MonoBehaviour
{
    public GameObject objCanva;
    void Start()
    {
        objCanva = GameObject.Find("Canvas");
        StartCoroutine(corutina());
    }

    IEnumerator corutina()
    {
        yield return new WaitForSeconds(4);
        objCanva.SetActive(false);
    }

}
