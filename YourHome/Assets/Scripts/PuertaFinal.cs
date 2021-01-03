using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaFinal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
           if(GameObject.Find("Jugador").GetComponent<PlayerController>().llavesRecogidas >= 4)
           {
               GameObject.Find("Bruja").GetComponent<BrujaNavController>().activa = false;
               GameObject.Find("Jugador").GetComponent<PlayerController>().jugadorGano = true;
           }
        }
    }
}
