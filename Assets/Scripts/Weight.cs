/*
            UNIVERSIDAD DEL VALLE DE GUATEMALA
        AUTOR: JOSE PABLO CIFUENTES SANCHEZ - 17509
        FECHA: 05/05/2018

        CREA UNA LINEA QUE SE VE COMO QUE LA PESA ESTUVIERA COLGANDO


*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour
{
    //Declaracion de variables
    LineRenderer line;
    DistanceJoint2D distanceJoint;

    // Use this for initialization
    void Start ()
    {
        //se extraen todas las componentes necesarias
        distanceJoint = GetComponent<DistanceJoint2D>();
        line = GetComponent<LineRenderer>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        //se actualiza las posiciones de la linea que conecta con la pesa
        line.SetPosition(0, transform.position);
        line.SetPosition(1,
        distanceJoint.connectedBody.transform.position);

    }
}
