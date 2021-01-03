using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rosario : MonoBehaviour
{
    public float speedRotation;
    public GameObject itemRosario;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        itemRosario.transform.Rotate(Vector3.up, speedRotation * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
 //          Debug.Log("Fireball ha golpeado a " + other.name);
           Destroy(this.gameObject);
           GameObject.Find("Jugador").GetComponent<PlayerController>().vidas_Rosarios += 1;
        }
    }
}
