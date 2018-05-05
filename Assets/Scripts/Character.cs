/*
            UNIVERSIDAD DEL VALLE DE GUATEMALA
        AUTOR: JOSE PABLO CIFUENTES SANCHEZ - 17509
        FECHA: 05/05/2018

        PERMITE MOVERSE AL PERSONAJE PRINCIPAL


*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour 
{

    //Declaracion de variables
    Rigidbody2D rb2d;
    SpriteRenderer sr;
    Animator anim;
    private float speed = 5f;
    private float jumpForce = 250f;
    private bool facingRight = true;
    public GameObject feet;
    public LayerMask layerMask;




    void Start () 
    {
        //se extrane las componentes necesarias
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        float move = Input.GetAxis("Horizontal");// almacena cuanto se mueve horizontalmente 
        if (move != 0)// si se esta moviendo
        {
            //hace el traslado de posicion
            rb2d.transform.Translate(new Vector3(1, 0, 0) * move * speed * Time.deltaTime);
            facingRight = move > 0;
        }

        //manda la variable de move
        anim.SetFloat("Speed", Mathf.Abs(move));

        sr.flipX = !facingRight;

        //si presiona el boton de jump
        if (Input.GetButtonDown("Jump"))
        {
            //crea an raycast
            RaycastHit2D raycast =
            Physics2D.Raycast(feet.transform.position, Vector2.down, 0.1f,
            layerMask);
            //si el rayo colapsa con algo puede saltar
            if (raycast.collider != null)
                rb2d.AddForce(Vector2.up * jumpForce);


        }
    }
}
