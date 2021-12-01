using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarCombate : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject MenuCombate;
    [SerializeField] GameObject player;



    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !collision.isTrigger)
        {
            MenuCombate.SetActive(true);
            player.SetActive(false);
            
        }
    }
}
