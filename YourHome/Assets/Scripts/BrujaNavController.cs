using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BrujaNavController : MonoBehaviour
{
    public Transform objetivo;
    private NavMeshAgent agente;

    public Animator animator;

    public List<string> animations = new List<string>();

    public bool activa = true;

    public bool partidaEnCurso = true;

    static AudioSource sound;
    public List<AudioClip> audios = new List<AudioClip>();

    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(activa)
        {
            if(partidaEnCurso){
                agente.destination = objetivo.position;
                animator.Play(animations[1]);
            }
        }else{
            animator.Play(animations[2]);
            agente.isStopped = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && activa)
        {
            if(GameObject.Find("Jugador").GetComponent<PlayerController>().vidas_Rosarios >= 1)
            {
                activa = false;
                StartCoroutine("unRosarioMenos");
                sound.PlayOneShot(audios[0]);
            }
            else
            {
                partidaEnCurso = false;
                agente.isStopped = false;
                GameObject.Find("Jugador").GetComponent<PlayerController>().vidas_Rosarios = -1;
                animator.Play(animations[0]);
                sound.PlayOneShot(audios[0]);
            }
        }
    }
    IEnumerator unRosarioMenos()
    {
        yield return new WaitForSeconds(3);
        GameObject.Find("Jugador").GetComponent<PlayerController>().vidas_Rosarios -= 1;
        activa = true;
    }
    
    public void corrutina()
    {
        StartCoroutine("noDanio");
    }
    IEnumerator noDanio()
    {
        yield return new WaitForSeconds(3);
        StartCoroutine("noDanio");
    }
}