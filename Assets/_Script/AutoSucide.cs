using UnityEngine;

public class AutoSucide : MonoBehaviour
{
    void Start()
    {
        Destroy(this.gameObject, 2f);
    }
}
