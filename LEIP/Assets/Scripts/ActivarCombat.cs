using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCombat : MonoBehaviour
{
    [SerializeField] Camera map;

    public GameObject MenuVillano;
    [SerializeField] GameObject player;

    public Vector2 playerPosition;
   
    public void ActivaCombate()
    {
        MenuVillano.SetActive(false);
        map.gameObject.SetActive(false);
    }

    public void CerrarBox()
    {
        MenuVillano.SetActive(false);
       // player.SetActive(true);
        
       
        //playerPosition = new Vector2 (-4.01f, 30.82f);

    }
}
