using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCombat : MonoBehaviour
{
    [SerializeField] Camera map;
    public GameObject MenuVillano;
    public void ActivaCombate()
    {
        MenuVillano.SetActive(false);
        map.gameObject.SetActive(false);
    }

    public void CerrarBox()
    {
        MenuVillano.SetActive(false);
    }
}
