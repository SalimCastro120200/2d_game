using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    public Jugador Rex;
    public Rigidbody2D enemigo;
    public float velocidad = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
        enemigo.GetComponent< Rigidbody2D >();


    }

    // Update is called once per frame
    void Update()
    {
        
        enemigo.velocity = new Vector2( -velocidad, enemigo.velocity.y);

    }

    private void OnTriggerEnter2D( Collider2D c1 ) {
        if( c1.tag == "Cuerpo" ) {
            Debug.Log( "M U E R T O" );
            Rex.audioMorir.Play();
            Rex.miAnimacion.SetBool( "Muerte", true );
            Rex.vidas--;
            Debug.Log( "Puntaje: " + Rex.puntaje + " Vidas restantes: " + Rex.vidas );
            Rex.Muerte = true;
            Rex.audioFondo.Stop();
        }

        // if( c1.tag == "Limite" ){

        //     velocidad*=-1;
        //     Vector3 escala=transform.localScale;
        //     escala.x*=-1;
        //     transform.localScale=escala;
        // }

        if( c1.tag == "Patitas" ){
            Destroy( gameObject );
            Debug.Log( "ENEMIGO MUERTO" );
        }
    }

}
