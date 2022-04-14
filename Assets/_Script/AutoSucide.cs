using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSucide : MonoBehaviour
{
    void Start()
    {
        Destroy(this.gameObject, 2f);
    }
}
