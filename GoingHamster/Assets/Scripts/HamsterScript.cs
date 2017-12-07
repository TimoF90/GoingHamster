using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HamsterScript : MonoBehaviour {

    public Rigidbody2D rb;
    public Rigidbody2D hook;
    public float releaseTime = 0.15f;
    public float MaxDragDistance = 2f;
    public float JumpEnergy = 5f;
    public float JumpPower = 100f;
    public GameObject HighscoreCanvas;
    public float yPosition;
    


    private bool isPressed = false;
    private int releaseCounter = 0;


    

    void Update()
    {
        if (isPressed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector3.Distance(mousePos, hook.position) > MaxDragDistance)
                rb.position = hook.position + (mousePos - hook.position).normalized * MaxDragDistance;

            else
                rb.position = mousePos;


        }

        
       

    }

    void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;

        
    }

    void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;

        StartCoroutine(Release());

        releaseCounter++;
        
    }

    

    IEnumerator Release()
    {

        yield return new WaitForSeconds(releaseTime);

        GetComponent<SpringJoint2D>().enabled = false;

        this.enabled = false;
    }

    
}
