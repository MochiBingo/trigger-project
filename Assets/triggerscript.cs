using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerscript : MonoBehaviour
{
    public GameObject plane;
    void OnTriggerEnter(Collider other)
    {
        plane.SetActive(true);
    }
}
