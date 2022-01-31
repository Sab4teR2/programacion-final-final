using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInvis : MonoBehaviour
{
    //Cuando uno de los balones deja de ser visible en la escena
    private void OnBecameInvisible()
    {
        //Desactivamos este balon de la escena

        this.gameObject.SetActive(false);

    }


}
