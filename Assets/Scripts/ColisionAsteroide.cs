using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionAsteroide : MonoBehaviour
{   
    private void OnCollisionEnter(Collision collision)
    {
        //Si el objeto contra el que colisionan es el balon
        if (collision.gameObject.CompareTag("Balon"))
        {
            //La puntuacion sube un gol
            Puntaje.scoreValue += 1;
            
            //y Desactivamos este balon de la escena
            collision.gameObject.SetActive(false);
        }
    }
}
