using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarControl : MonoBehaviour
{

    public GameObject Pregunta;
    public GameObject player;
    public GameObject colision;

    public void Control()
    {
        Pregunta.SetActive(false);
        player.SetActive(true);
        colision.SetActive(false);
    }
}
