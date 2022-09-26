using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXSpawn : MonoBehaviour
{
    public ParticleSystem particle;

    public void InstntiateMethod()
    {
        particle.Play();
    }
}
