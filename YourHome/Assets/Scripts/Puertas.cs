using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : MonoBehaviour
{
    public bool abierta = false;
    public Animator animacion;
    public List<string> animaciones = new List<string>();
    public Collider other;

    // Start is called before the first frame update
    void Start()
    {
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(abierta == false)
        {
            if (other.tag == "Player")
            {
                animacion.Play(animaciones[0]);
                abierta = true;
            }
        }
           
    }
}
