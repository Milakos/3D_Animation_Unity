using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventKinematic : MonoBehaviour
{
    Rigidbody rb;
    StandUp stup;
    private void Start() 
    {
        rb = GetComponent<Rigidbody>();  
        stup = FindObjectOfType<StandUp>();  
    }
    private void LateUpdate() 
    {
        eventkinematicListener();
    }
    public void eventkinematicListener()
    {
        if (stup.kinem == true)
        {
            rb.isKinematic = false;
        }
        
    }
}
