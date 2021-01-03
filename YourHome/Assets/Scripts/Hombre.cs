using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hombre : MonoBehaviour
{
    public GameObject pausa;
    public Text lbl_gameOver;
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
        if (other.tag == "Bruja")
        {
            GameObject.Find("Jugador").GetComponent<PlayerController>().llavesRecogidas -= 1;

            if (GameObject.Find("Jugador").GetComponent<PlayerController>().llavesRecogidas == 0)
            {
                pausa.SetActive(true);
                Time.timeScale = 0f;
                lbl_gameOver.text = "Has muerto";
          
            }
        }
    }
}
