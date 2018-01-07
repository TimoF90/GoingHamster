using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class SpinScript : MonoBehaviour
{
    public float speed;

    private HamsterScript theHamsterScript;
    public Rigidbody2D rb;

    private float touchStartTime;

    private bool ispressed = false;
    private float speed1, time;

    // Use this for initialization
    void Start()
    {
        theHamsterScript = FindObjectOfType<HamsterScript>();

    }

    // Update is called once per frame
    void Update()
    {

        RightSpin();
        LeftSpin();


    }





    public void RightSpin()
    {

        if(Input.GetButtonDown("Fire1"))
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);





    }


    public void LeftSpin()
    {
        if (Input.GetButtonDown("Fire1"))
            transform.Rotate(-Vector3.forward * speed * Time.deltaTime);

    }
}
