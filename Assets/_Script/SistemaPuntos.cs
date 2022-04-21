using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaPuntos : MonoBehaviour
{
    public GameObject _canastaRandom;
    public GameObject _enemigo;
    public GameObject _positionBall;
    public Transform _ball;
    public Transform _canasta;
    public Text _scoreText;
    public SpawnConfetti _spawnConfetti;
    public bool _encesto = default;
    public bool _preparando = true;
    private int _currentScore;
    public Animator _anim;
    public Rigidbody _rbball;

    private void Update()
    {
        if (_preparando == true)
        {
            _ball.transform.position = new Vector3(_positionBall.transform.position.x, _positionBall.transform.position.y, _positionBall.transform.position.z);
        }

        
    }

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
            _enemigo.transform.position = new Vector3(_canasta.transform.position.x + Random.Range(10, 15), _canasta.transform.position.y - 8, _canasta.transform.position.z + Random.Range(-10, 10));
            _preparando = true;
            _rbball.constraints = RigidbodyConstraints.FreezePosition;
            StartCoroutine(Manos());
            _rbball.constraints = RigidbodyConstraints.None;
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