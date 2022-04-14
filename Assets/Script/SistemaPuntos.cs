using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SistemaPuntos : MonoBehaviour
{
    private int currentScore;
    public TextMeshProUGUI scoreText;
    public GameObject _canastaRandom;
    public Transform _canasta;
    public bool _encesto = default;
    public Transform _ball;
    public GameObject _enemigo;
    public SpawnConfetti _spawnConfetti;

    void Start()
    {
        currentScore = 0;
    }

    private void Update()
    {
    }

    private void HandleScore()
    {
        scoreText.text = "Score: " + currentScore.ToString();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Tocando");
            currentScore ++;
            HandleScore();
            _encesto = true;
        }

        if (_encesto == true )
        {
            _spawnConfetti.Confeti();
            _canastaRandom.transform.position = new Vector3(Random.Range(-45f, -15f), 7.4f, Random.Range(45f, -45f));
            _enemigo.transform.position = new Vector3(_canasta.transform.position.x + Random.Range(10, 15), _canasta.transform.position.y - 8, _canasta.transform.position.z + Random.Range(-10, 10));

            _ball.transform.position = new Vector3(0, 3f, 0);
        }

        if(other.gameObject.CompareTag("Piso"))
        {
            _ball.transform.position = new Vector3(0, 3f, 0);
        }

       


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) _encesto = false;
        
    }

    
}