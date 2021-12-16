using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCombat : MonoBehaviour
{
    [SerializeField] Camera map;

    public GameObject MenuVillano;
    public GameObject player;
    public Transform teleportTarget;
    public Animator Anim;
    public Vector2 playerPosition;
    public  GameObject colision;
    public GameObject camaraCombate;

    public GameObject musica1;
    public GameObject musica2;

    public void ActivaCombate()
    {
        camaraCombate.SetActive(true);
        MenuVillano.SetActive(false);
        colision.SetActive(false);
        Anim.SetTrigger("Star");
        player.SetActive(true);
        musica1.SetActive(false);
        musica2.SetActive(true);
        StartCoroutine(WaitForNext());
    }
    IEnumerator WaitForNext()
    {
        yield return new WaitForSeconds(1);
        map.gameObject.SetActive(false);
        player.SetActive(false);
    }
   

    public void CerrarBox()
    {

        player.transform.position = teleportTarget.transform.position;
        MenuVillano.SetActive(false);
        player.SetActive(true);
        
    }
}
