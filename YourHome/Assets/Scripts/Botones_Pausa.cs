using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botones_Pausa : MonoBehaviour
{
    public List<KeyCode> keys = new List<KeyCode>();
    public bool pausaJuego = false;
    public bool verInstrucciones = false;
    public Text hasPerdido;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            SceneManager.LoadScene("");
        }
        if (Input.GetKeyDown(keys[0]))
        {
            if (pausaJuego)
            {
                reanudar();
                cerrarInstrucciones();
            }
            else
            {
                pausa();
            }
        }
    }
    public void pausa()
    {
        pausaJuego = true;
        //panel_pausa.SetActive(pausaJuego);
        Time.timeScale = 0f;
    }
    public void reanudar()
    {
        pausaJuego = false;
        //panel_pausa.SetActive(pausaJuego);
        Time.timeScale = 1f;
    }
    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void abrirInstrucciones()
    {
        verInstrucciones = true;
        //panel_instrucciones.SetActive(verInstrucciones);
    }
    public void cerrarInstrucciones()
    {
        verInstrucciones = false;
        //panel_instrucciones.SetActive(verInstrucciones);
    }
}
