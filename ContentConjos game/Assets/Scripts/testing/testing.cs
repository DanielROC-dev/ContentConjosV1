using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    private float startTime;
    private float endTime;
    bool mouseUp;
   
    public Animator animator;

   /* void OnMouseDown() 
    {
        Debug.Log("mouse up");
    }*/
    
    void start()
    {
        startTime = 0f;
        endTime = 0f; 
        mouseUp = false;
        
    }
    
    void OnMouseDown() 
    {
        if(Input.GetMouseButtonDown(0))
        {
            startTime = Time.time;
            animator.SetBool("mouseOnTarget", true);
        }
    }

    void OnMouseUp()
    {
        if(Input.GetMouseButtonUp(0))
        {
            endTime = Time.time;
        }
        mouseUp = true;
    }

    void Update()
    {   
        if(mouseUp == true){
            Debug.Log("bruh");
            mouseUp = false;
        }

        if(endTime - startTime > 0.5f)
        {
            Debug.Log(endTime - startTime);
            animator.SetBool("mouseOnTarget", false);
            startTime = 0f;
            endTime = 0f;
        }       
    } 
   
}
