using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parabola : MonoBehaviour
{
    [SerializeField]
    public GameObject ball;
    public Transform target;
    private Animator _animator;

    [SerializeField]
    public float height = 10;
    public float gravity = -9.8f;
     
    [SerializeField]
    private Rigidbody rbBall;

    private void Start()
    {
        rbBall = ball.GetComponent<Rigidbody>();
        
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Launch();
            
        }
    }

    public void Launch()
    {
        Physics.gravity = Vector3.up * gravity;
        rbBall.useGravity = true;
        rbBall.velocity = GetInicialVelocity();
        

    }

    public Vector3 GetInicialVelocity()
    {
        Vector3 distance = target.position - ball.transform.position;

        float XVelocity, YVelocity, ZVelocity;

        YVelocity = Mathf.Sqrt(-2.0f * gravity * height);
        XVelocity = (distance.x) / ((-YVelocity / gravity) + (Mathf.Sqrt((2.0f * (distance.y - height)) / gravity)));
        ZVelocity = (distance.z) / ((-YVelocity / gravity) + (Mathf.Sqrt((2.0f * (distance.y - height)) / gravity)));

        return new Vector3(XVelocity, YVelocity, ZVelocity);
    }

}
