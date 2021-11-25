using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] 
public class ImageNPC
{
    [SerializeField] GameObject imagen;
    public GameObject Imagen
    {
        get { return imagen; }
    }
    public void abrir()
    {
       imagen.SetActive(true);
    }
    public void cerrar()
    {
        imagen.SetActive(false);
    }

}

