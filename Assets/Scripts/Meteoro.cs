﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoro : MonoBehaviour
{

    public Jugador Rex;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D( Collider2D c1 ) {
        if( c1.tag == "Cuerpo" ) {
            Rex.puntaje++;
            Rex.audioMeteoro.Play();
            Destroy( gameObject );
            Debug.Log( "Puntaje: " + Rex.puntaje );
        }
    }

}
