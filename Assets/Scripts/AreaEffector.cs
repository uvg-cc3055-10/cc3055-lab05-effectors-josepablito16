/*
            UNIVERSIDAD DEL VALLE DE GUATEMALA
        AUTOR: JOSE PABLO CIFUENTES SANCHEZ - 17509
        FECHA: 05/05/2018

        ACTIVA Y DESACTIVA DESOUES DE CIERTO TIEMPO EL EFECTO


*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour
{
    //Declaracion de variables
    float time;
    bool control = false;
    
    // Use this for initialization
    void Start ()
    {
      		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //se aumenta el tiempo cada cambio de frame
        time += Time.deltaTime;

            //si el tiempo llega a pasar de 10 se desactiva el efecto y se vuelve a activar
            if (time > 10)
            {
                gameObject.SetActive(false);
                gameObject.SetActive(true);
                control = true;
                //se reinicia el tiempo
                time = 0;
            }

      

        
        Debug.Log(time);




    }
}
