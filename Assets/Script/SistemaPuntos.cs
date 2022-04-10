using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SistemaPuntos : MonoBehaviour
{
    public TextMesh textoContador;
    private int puntuacion = 0;
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log (other.gameObject.tag);
        if (other.gameObject.tag == "collectable")
        {
            puntuacion = puntuacion + 1;
            textoContador.text = puntuacion.ToString();
        }
    }
}
