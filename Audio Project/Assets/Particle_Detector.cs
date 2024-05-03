using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Detector : MonoBehaviour
{
    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {
        particle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            particle.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            particle.SetActive(false);
        }
    }
}
