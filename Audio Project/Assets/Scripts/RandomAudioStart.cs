using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudioStart : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip[] audioClips;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
        audioSource.time = Random.Range(0f, audioSource.clip.length);
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
