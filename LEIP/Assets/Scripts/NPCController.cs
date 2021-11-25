using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NPCController : MonoBehaviour, Interactable
{
  [SerializeField] Dialog dialog;
  [SerializeField] ImageNPC FaceImage;
  public void Interact()
    {
        StartCoroutine(DialogManager.Instance.ShowDialog(dialog, FaceImage));
    }
}
