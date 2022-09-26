using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
public class White : MonoBehaviour
{
    WhiteBalance whiteBalance;

    [Range(-100, 100)]
    public int tempFactor = 10;
    Volume volume;
    
    // Start is called before the first frame update
    void Start()
    {   
        whiteBalance = GetComponent<WhiteBalance>();
        whiteBalance.temperature.Override(tempFactor);
        volume = GetComponent<Volume>();
    }

    // Update is called once per frame
    void Update()
    {
        // whiteBalance.temperature.value = tempFactor * Time.deltaTime;

        
        if (volume.profile.TryGet<WhiteBalance>(out var whiteBalance))
            {
                whiteBalance.temperature.overrideState = true;
                whiteBalance.temperature.value = tempFactor;
            }
    }
}
