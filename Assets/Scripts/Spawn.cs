using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Hacemos referencia al objeto que queremos hacer aparecer en este caso un balon
    public GameObject balon;

    void Start()
    {

    }

    void Update()
    {
        //Los balones apareceran si el numero aleatorio entre 0 y 300 sale menor que 1
        if (Random.Range(0, 300) < 1)
        {

            //Creamos una referencia al objeto de la lista de objetos creados mediante el Pool
            GameObject a = Pool.singleton.Get("Balon");
            //Si el objeto que he recibido no está vacío(osea que se puede usar)
            if (a != null)
            {
                //Le pasamos una posición a ese balon concreto
                a.transform.position = this.transform.position + new Vector3(Random.Range(-10, 10), 0, 0);
                //Y activamos el balon
                a.SetActive(true);
            }
        }

    }
}
