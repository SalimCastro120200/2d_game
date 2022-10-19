using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatasJugador : MonoBehaviour
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

    private void OnTriggerEnter2D( Collider2D c1 ){

        if( c1.tag == "Plataforma" ){
            Rex.EnPiso = true;
            Rex.miAnimacion.SetFloat( "FuerzaSalto", 0 );
        }

        if( c1.tag == "Agua" ){
            Rex.miAnimacion.SetBool( "Muerte", true );
            Rex.audioMorir.Play();
            // Rex.Rex.constraints = RigidbodyConstraints2D.FreezeAll;
            Rex.Muerte = true;
            Rex.audioFondo.Stop();
        }

    }
    
    private void OnTriggerExit2D( Collider2D c2 ){

        if( c2.tag == "Plataforma" ){
            Rex.EnPiso = false;
        }

    }

}
