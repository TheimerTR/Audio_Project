using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkByFoot : MonoBehaviour
{
    public AudioSource footGrass;
    public AudioSource footWood;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Grass")
        {
            footGrass.Play();
        }
        if (other.gameObject.tag == "Wood")
        {
            footWood.Play();
        }
    }

}
