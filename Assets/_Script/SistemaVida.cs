using UnityEngine;
using UnityEngine.SceneManagement;


public class SistemaVida : MonoBehaviour
{
    [SerializeField]
    public static int vidas = 3;
    public int vidaPublic;
    public bool HacerDa�o = true;
    public SistemaPuntos _sistemaPuntos;

    void Update()
    {
        vidaPublic = vidas;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (!HacerDa�o) return;

        if (collision.CompareTag("Enemy"))
        {
            HacerDa�o = false;
            Invoke("ActDano", 1);
            vidas -= 1;
            _sistemaPuntos._rbball.constraints = RigidbodyConstraints.FreezePosition;
            _sistemaPuntos._ball.transform.position = new Vector3(0, 3f, 0);
            _sistemaPuntos._rbball.constraints = RigidbodyConstraints.None;
            if (Vidas.vidas != null)
            {
                Vidas.vidas.MenosVida();
            }

            if (vidas <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    void ActDano()
    {
        HacerDa�o = true;
    }
}