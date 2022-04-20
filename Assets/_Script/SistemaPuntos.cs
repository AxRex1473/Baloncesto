using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaPuntos : MonoBehaviour
{
    public GameObject _canastaRandom;
    public GameObject _enemigo;
    public Transform _ball;
    public Transform _canasta;
    public TextMesh _scoreText;
    public SpawnConfetti _spawnConfetti;
    public bool _encesto = default;
    private int _currentScore;
    public Animator _anim;
    public Rigidbody _rbball;

    void Start()
    {
        _currentScore = 0;
    }

    private void HandleScore()
    {
        _scoreText.text = "Score: " + _currentScore.ToString();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Tocando");
            _currentScore++;
            HandleScore();
            _encesto = true;
        }

        if (_encesto == true)
        {
            _spawnConfetti.Confeti();
            _canastaRandom.transform.position = new Vector3(Random.Range(-45f, -15f), 7.4f, Random.Range(45f, -45f));
            _enemigo.transform.position = new Vector3(_canasta.transform.position.x + Random.Range(10, 15), _canasta.transform.position.y - 8, _canasta.transform.position.z + Random.Range(-10, 10));
            _ball.transform.position = new Vector3(0, 3f, 0);
            _rbball.constraints = RigidbodyConstraints.FreezePosition;
            StartCoroutine(Manos());
            _rbball.constraints = RigidbodyConstraints.None;
        }

        if (other.gameObject.CompareTag("Piso"))
        {
            _ball.transform.position = new Vector3(0, 3f, 0);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) _encesto = false;
    }

    IEnumerator Manos()
    {
        _anim.SetBool("ManosAnim", true);
        yield return new WaitForSeconds(3);
        _anim.SetBool("ManosAnim", false);
    }
}