using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SistemaPuntos : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI Text;
    public int score = 0;

    private void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Puntos")
        {
            score = score + 1;
            Text.text = Text.ToString();
        }
    }
}