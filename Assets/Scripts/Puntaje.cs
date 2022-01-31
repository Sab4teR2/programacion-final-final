using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Puntaje : MonoBehaviour
{
    //Creamos una variable para saber los goles que hemos marcado, comenzando por 0
    public static int scoreValue = 0;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos el texto
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {   //se pinta en pantalla el score de Golazos + la puntuacion del momento
        score.text = "Golazos: " + scoreValue;
    }
}
