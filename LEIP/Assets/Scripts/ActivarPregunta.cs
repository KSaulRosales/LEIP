using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPregunta : MonoBehaviour
{
    public GameObject Pregunta;
    public GameObject player;
    public Transform teleportTarget;
    public GameObject colision;
    public Vector2 playerPosition;

    public void si()
    {
        Pregunta.SetActive(false);
        player.SetActive(true);
        colision.SetActive(false);
    }

    public void CerrarBox()
    {

        player.transform.position = teleportTarget.transform.position;
        Pregunta.SetActive(false);
        player.SetActive(true);

    }
}
