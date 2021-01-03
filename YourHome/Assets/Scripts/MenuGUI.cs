using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGUI : MonoBehaviour
{
    //public GameObject panel;
    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void loadGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void loadNarrativeI()
    {
        SceneManager.LoadScene("NarrativaI");
    }
    public void loadNarrativeF()
    {
        SceneManager.LoadScene("NarrativaF");
    }
    public void loadInstruccions()
    {
        SceneManager.LoadScene("Instrucciones");
    }
}
