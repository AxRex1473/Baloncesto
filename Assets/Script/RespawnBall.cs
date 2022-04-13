using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBall : MonoBehaviour
{
    public Transform _ball;
    public SistemaPuntos _sistemaDePuntos;

    void Update()
    {
        if (_sistemaDePuntos._encesto == true)
        {
            SpawnPoint();
        }
    }

    public void SpawnPoint()
    {
        _ball.transform.position = new Vector3(0,3f,0);
    }
}
