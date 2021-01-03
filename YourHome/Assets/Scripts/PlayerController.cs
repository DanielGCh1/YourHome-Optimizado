using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;

    public Animator animator;
    public List<string> animations = new List<string>();
    public List<KeyCode> keys = new List<KeyCode>();
    private Rigidbody rb;

    public int vidas_Rosarios;
    public int llavesRecogidas;

    public bool activo = true;

    public bool jugadorGano = false;
    

    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        vidas_Rosarios = 0;
        llavesRecogidas = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if(activo)
        {
            Vector3 rot = transform.rotation.eulerAngles;

            if (Input.GetKey(keys[0])) //A(izquierda) o control
            {
                //rb.position += Vector3.right * speed * Time.deltaTime;  
                animator.Play(animations[1]);               
            }
            if (Input.GetKey(keys[1])) //D(derecha) o control
            {
                //rb.position += Vector3.left * speed * Time.deltaTime;
                animator.Play(animations[1]);
            }
            if (Input.GetKey(keys[2])) //A(izquierda) o control
            {
                //rb.position += Vector3.right * speed * Time.deltaTime;
                animator.Play(animations[1]);
            }
            if (Input.GetKey(keys[3])) //D(derecha) o control
            {
                //rb.position += Vector3.left * speed * Time.deltaTime;
                animator.Play(animations[1]);
            }
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
            
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemigo")
        {
           if(vidas_Rosarios <= 0)
           {
               activo = false;
               StartCoroutine("perder");
           }
        }
    }
    IEnumerator perder()
    {
        yield return new WaitForSeconds(3);
        
    }
}
