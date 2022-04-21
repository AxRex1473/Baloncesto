using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public CharacterController characterController;
    public float velocity = default;
    public Vector3 move = default;
    public SistemaPuntos sistemaPuntos;

    void Update()
    {
        var _moveHorizontal = Input.GetAxis("Horizontal");
        var _moveVertical = Input.GetAxis("Vertical");
        move = transform.right * _moveVertical + transform.forward * -_moveHorizontal;
        characterController.Move(move * velocity * Time.deltaTime);
    }
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            sistemaPuntos._preparando = true;
        }
    }
}
