using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject _enemigo;
    private Vector3 _scaleChange;
    public float _tiempo;

    void Start()
    {
        _scaleChange = new Vector3(0f, 0.1f, 0f);
    }
    
    void Update()
    {
        _enemigo.transform.localScale += _scaleChange * Time.deltaTime * _tiempo;
        if (_enemigo.transform.localScale.y >= 4f)
        {
            _scaleChange = -_scaleChange;
           
        }
        if (_enemigo.transform.localScale.y <= 1.5f)
        {
            _scaleChange = new Vector3(0f, 0.1f, 0f);
        }
    }
}
