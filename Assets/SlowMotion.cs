using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{

    public float slowFactor = 1.0f;

    private void Awake() 
    {
        Time.timeScale = slowFactor;    
    }
    // Update is called once per frame
    void Update()
    {
        Time.timeScale = slowFactor;
    }
}
