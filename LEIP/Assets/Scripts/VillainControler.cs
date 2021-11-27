using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class VillainControler : MonoBehaviour, Interactable
{
    [SerializeField] Dialog dialog;
    [SerializeField] ImageNPC FaceImage;
    public void Interact()
    {
        StartCoroutine(DialogManagerV.Instance.ShowDialog(dialog, FaceImage));
     
    }
}
