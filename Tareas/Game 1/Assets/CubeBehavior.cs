using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour {

    public float speed;
    public float points;
    

	// Use this for initialization

	void Start () {

        /*
         * Impresion inicial de los puntos que tiene el jugador
         */
        print("Empiezas con " + points + " puntos.\nLas esferas rojas son tus enemigas." +
            "intenta llegar hasta el rectangulo de color azul");
	}
	
	

	void Update () {

        /*
         * El jugador solo puede moverse de manera horizontal
         */

        float h = Input.GetAxisRaw("Horizontal");

        transform.Translate(h * speed * Time.deltaTime,
                            0,
                            0);

    }

    void OnCollisionEnter(Collision c){

        //print("Collision with: " + c.transform.tag);

        /*
         * Si es que el jugador golpea cualquier cosa que no sea
         * el objetivo final se le removera un punto. al llegar a tocar
         * al punto final de le otorga un punto.
         */

        if (c.transform.tag != "Finish")
        {
            points -= 1;
            print("Ahora tienes " + points + " puntos.");
        }
        else if (c.transform.tag == "Finish")
        {
            points += 1;
            print("Ahora tienes " + points + " puntos.");
        }

    }

    void OnCollisionStay(Collision c){

        /*
         * Se continuan quitando puntos si es que el jugador se mantiene en 
         * donde hay un enemigo
         */

        if (c.transform.tag != "Finish")
        {
            points -= 1;
            print("Ahora tienes " + points + " puntos.");
        }
    }

}
