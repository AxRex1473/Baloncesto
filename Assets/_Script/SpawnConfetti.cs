using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnConfetti : MonoBehaviour
{
    public GameObject confettiFx;
    public Transform _vectorConfeti;
    public void Confeti()
    {
        //GameObject ob = Instantiate(confettiFx, new Vector3 (_vectorConfeti.transform.position.x, _vectorConfeti.transform.position.y, _vectorConfeti.transform.position.z), Quaternion.identity);
        //GameObject ob = Instantiate(confettiFx);
        Destroy(ob, 4f);
    }
}
