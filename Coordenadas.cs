using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coordenadas : MonoBehaviour
{
    // Lista de objetos a los que vamos a hacer seguimiento
    public GameObject[] objetos;

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject obj in objetos)
        {
            if (obj != null)
            {
                Debug.Log(obj.name + " posición: " + obj.transform.position);
            }
        }
    }
}
