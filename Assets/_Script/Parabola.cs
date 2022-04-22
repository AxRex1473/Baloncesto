using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parabola : MonoBehaviour
{
    [SerializeField]
    public GameObject ball;
    public Transform target;

    [SerializeField]
    public float height = 10;
    public float gravity = -9.8f;
    public bool pass = true;
    public float velocidad;

    [SerializeField]
    private Rigidbody rbBall;
    public SistemaPuntos sistemaPuntos;
    //public bool _lanzado;

    public Slider slider;
    public int heightMax = 50;
    public Image barra;

    private void Start()
    {
        rbBall.useGravity = false;
        rbBall = ball.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        slider.value = height/heightMax;
        if (height >= 27)
        {
            barra.color = Color.yellow;
            
            if (height>= 36)
            {
                barra.color = Color.red;
            }
            
        }
        else
        {
            barra.color = Color.green;
        }

        if (pass == true)
        {
            if (Input.GetKey(KeyCode.Space) && sistemaPuntos._preparando == true)
            {
                height = height + 5f * Time.deltaTime;
                if (height >= 50)
                {
                    sistemaPuntos._preparando = false;
                    rbBall.useGravity = true;
                    Launch();
                    height = 12f;
                    pass = false;

                    

                }
            }
            if (Input.GetKeyUp(KeyCode.Space) && sistemaPuntos._preparando == true)
            {
                sistemaPuntos._preparando = false;

                rbBall.useGravity = true;
                Launch();
                height = 12f;
            }
            
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
        XVelocity = (distance.x) / ((-YVelocity / gravity) + (Mathf.Sqrt((1.0f * (distance.y - height)) / gravity)));
        ZVelocity = (distance.z) / ((-YVelocity / gravity) + (Mathf.Sqrt((1.0f * (distance.y - height)) / gravity)));
        return new Vector3(XVelocity, YVelocity, ZVelocity);
    }
    
}
