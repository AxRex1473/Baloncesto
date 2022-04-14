using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject enemigo;
    private Vector3 scaleChange;
    public float tiempo;
    SistemaPuntos _sistemPoint;
    void Start()
    {
        scaleChange = new Vector3(0f, 0.1f, 0f);
    }

    
    void Update()
    {
        enemigo.transform.localScale += scaleChange * Time.deltaTime * tiempo;
        if (enemigo.transform.localScale.y >= 4f)
        {
            scaleChange = -scaleChange;
           
        }
        if (enemigo.transform.localScale.y <= 1.5f)
        {
            scaleChange = new Vector3(0f, 0.1f, 0f);
        }

    }
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _sistemPoint._ball.transform.position = new Vector3(0, 3f, 0);

        }

    }*/




    /*void Creciendo()
    {
        enemigo.transform.localScale.y++;

    }
    IEnumerator creciendo()
    {
        yield return new WaitForSeconds(2f);
        enemigo.transform.localScale.y = Time.deltaTime

    }*/
}
