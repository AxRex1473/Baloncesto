using UnityEngine;
using UnityEngine.SceneManagement;


public class SistemaVida : MonoBehaviour
{
    [SerializeField]
    public static int vidas = 3;
    public int vidaPublic;
    public bool HacerDaño = true;
    public SistemaPuntos _sistemaPuntos;
    public Rigidbody _rbball;

    void Update()
    {
        vidaPublic = vidas;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (!HacerDaño) return;

        if (collision.CompareTag("Enemy"))
        {
            _rbball.useGravity = false;
            HacerDaño = false;
            Invoke("ActDano", 1);
            vidas -= 1;
            _sistemaPuntos._rbball.constraints = RigidbodyConstraints.FreezePosition;
            _sistemaPuntos._ball.transform.position = new Vector3(_sistemaPuntos._positionBall.transform.position.x, _sistemaPuntos._positionBall.transform.position.y, _sistemaPuntos._positionBall.transform.position.z);
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
        HacerDaño = true;
    }
}