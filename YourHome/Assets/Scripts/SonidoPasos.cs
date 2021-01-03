using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoPasos : MonoBehaviour
{
    public AudioSource pie;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "piso")
        {
            pie.Play();
        }
    }
}
