using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandUp : MonoBehaviour
{
    public ParticleSystem part;

    public GameObject obj;
    public Vector3 trans;
    public Vector3 objTrans;
    public GameObject go;
    Animator anim;
    public float slowfactor =1f;
    public bool kinem;
    private void Awake() 
    {
        anim = GetComponent<Animator>();
    }
    private void Update() 
    {
        Time.timeScale = slowfactor;
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "S")
        {
            anim.SetBool("Stand", true);
            
        }  
        if(other.tag == "D")
        {
            anim.SetBool("Dodge", true);
            Instantiate(obj, objTrans, Quaternion.identity);
            kinem = true;
        }   
    }

    public void Death()
    {
        Instantiate(part, trans, Quaternion.identity);
        Destroy(go, 0.7f);
    }

}

