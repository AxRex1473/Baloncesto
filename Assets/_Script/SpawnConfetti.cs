using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnConfetti : MonoBehaviour
{
    public GameObject _confettiFx;
    public Transform _vectorConfeti;

    public void Confeti()
    {
        GameObject ob = Instantiate(_confettiFx);
        Destroy(ob, 4f);
    }
}
