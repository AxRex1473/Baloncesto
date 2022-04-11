using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaVida : MonoBehaviour
{
    [SerializeField]
    public static int vidas = 3;
    public int vidaPublic;
    public bool HacerDa�o = true;

    // Start is called before the first frame update
    void Start()
    {
        //vidas = 3;
    }

    // Update is called once per frame
    void Update()
    {
        vidaPublic = vidas;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (!HacerDa�o)
            return;

        if (collision.CompareTag("Enemy"))
        {
            HacerDa�o = false;
            Invoke("ActDano", 1);
            vidas -= 1;

            if (Vidas.vidas != null)
            {
                Vidas.vidas.MenosVida();
            }

            if (vidas <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    void ActDano()
    {
        HacerDa�o = true;
    }
}