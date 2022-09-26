using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vfxInstance : MonoBehaviour
{
    public GameObject go;
    void Start() 
    {
        
        StartCoroutine(Instanc());
    
            
    }
    IEnumerator Instanc()
    {
        yield return new WaitForSeconds(51);
        Instantiate(go, transform.localPosition, Quaternion.identity);
    }
}
