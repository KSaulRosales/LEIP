using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pregunta : MonoBehaviour
{
    public GameObject Menupregunta;
    [SerializeField] GameObject player;



    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !collision.isTrigger)
        {
            Menupregunta.SetActive(true);
            player.SetActive(false);

        }
    }
}
