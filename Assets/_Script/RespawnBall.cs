using UnityEngine;

public class RespawnBall : MonoBehaviour
{
    public SistemaPuntos _sistemaPuntos;
    public Transform _positionPlayer;
    public Transform _spawnPlayerAgain;

    void Update()
    {
        if (_sistemaPuntos._encesto == true)
        {
            SpawnPoint();
        }
    }

    public void SpawnPoint()
    {
       
        _positionPlayer.transform.position = new Vector3(_spawnPlayerAgain.transform.position.x, _spawnPlayerAgain.transform.position.y, _spawnPlayerAgain.transform.position.z);
    }
}
