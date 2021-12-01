using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCombat : MonoBehaviour
{
    [SerializeField] Camera map;

    public GameObject MenuVillano;
    public GameObject player;
    public Transform teleportTarget;

    public Vector2 playerPosition;
   
    public void ActivaCombate()
    {
        MenuVillano.SetActive(false);
        map.gameObject.SetActive(false);
    }

    public void CerrarBox()
    {

        player.transform.position = teleportTarget.transform.position;
        MenuVillano.SetActive(false);
        player.SetActive(true);
        
    }
}
