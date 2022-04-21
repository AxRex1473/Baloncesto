using System.Collections.Generic;
using UnityEngine;

public class Vidas : MonoBehaviour
{
    [SerializeField]
    public GameObject[] Vida;

    [SerializeField]
    public Queue<GameObject> VidasFilas = new Queue<GameObject>();
    public static Vidas vidas;

    void Start()
    {
        vidas = this;
        foreach(GameObject g in Vida)
        {
            VidasFilas.Enqueue(g);
            g.gameObject.SetActive(true);
        }
    }

    public void MenosVida()
    {
        GameObject g = VidasFilas.Dequeue();
        g.gameObject.SetActive(false);
        VidasFilas.Enqueue(g);
    }
}
