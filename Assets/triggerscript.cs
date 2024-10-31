using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerscript : MonoBehaviour
{
    public GameObject plane;
    public AudioClip clip;
    void OnTriggerEnter(Collider other)
    {
        plane.SetActive(true);
        AudioSource audio= GetComponent<AudioSource>();
        audio.Play();
        audio.clip = clip;
        audio.Play();
    }
}
