using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameGUI : MonoBehaviour
{
    public Text lbl_llave;
    public Text lbl_rosario;
    public List<KeyCode> keys = new List<KeyCode>();
    public bool pausaJuego = false;
    public GameObject panelPausa;
    public Text lnl_gameover;

    public bool perdio = false;

    public bool gano = false;

    // Start is called before the first frame update
    void Start()
    {
        pausa();
    }

    // Update is called once per frame
    void Update()
    {
        lbl_llave.text = "X " + GameObject.Find("Jugador").GetComponent<PlayerController>().llavesRecogidas.ToString();
        lbl_rosario.text = "X " + GameObject.Find("Jugador").GetComponent<PlayerController>().vidas_Rosarios.ToString();

        if (Input.GetKeyDown(keys[0]))
        {
            if (pausaJuego)
            {
                reanudar();
            }
            else
            {
                pausa();
                
            }
            
        }
        if (Input.GetKeyDown(keys[1]))
        {
            SceneManager.LoadScene("Game");
        }
        if (Input.GetKeyDown(keys[2]))
        {
            SceneManager.LoadScene("Menu");
        }

        if (GameObject.Find("Jugador").GetComponent<PlayerController>().vidas_Rosarios == -1)
        {
            gameOver();
            panelPausa.SetActive(true);
            lnl_gameover.text = "Has Perdido";
        }

        if(GameObject.Find("Jugador").GetComponent<PlayerController>().jugadorGano)
        {
            SceneManager.LoadScene("NarrativaF");
            gameOver();
        }
    }
    public void pausa()
    {
        pausaJuego = true;
        panelPausa.SetActive(pausaJuego);
        Time.timeScale = 0f;
    
    }
    public void reanudar()
    {
        pausaJuego = false;
        panelPausa.SetActive(pausaJuego);
        Time.timeScale = 1f;
    }
    public void gameOver()
    {
        StartCoroutine("endGame");
    }
    IEnumerable endGame()
    {
        yield return new WaitForSeconds(2);
    }
}
