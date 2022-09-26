using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MIning : MonoBehaviour
{
    ParticleSystem part;

    private void Awake() 
    {
        part = GetComponent<ParticleSystem>();    
    }
    void Update()
    {
        
    }
}
