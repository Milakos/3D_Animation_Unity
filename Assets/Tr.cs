using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.timeScale = 0.1f;
        Destroy(this.gameObject, 5f);
    }
}
