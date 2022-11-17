using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDecoy : MonoBehaviour
{
    public GameObject Player;
    ParticleSystem Particles;
    void Start()
    {
        Particles = GetComponent<ParticleSystem>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " triggered into " + gameObject.name);
        Particles.Play();

    }     

}