using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEnemigo : MonoBehaviour
{
    public GameObject area;
    public GameObject flecha_;
    public bool vivo = true;
    void Start()
    {
            StartCoroutine(ataque());
    }

    IEnumerator ataque()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(5,10));
        GameObject flecha = Instantiate(flecha_, area.transform.position,
               area.transform.rotation) as GameObject;
        Destroy(flecha, 1);
        while (vivo)
        {
            StartCoroutine(ataque());
        }
    }
}
