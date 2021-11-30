using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { FreeRoam, Dialog }

public class GameController : MonoBehaviour
{
    [SerializeField] Player playerController;
   
    GameState state;
   
    public static GameController Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
    }
    int npc = 0;
    public void verificar(int npc1)
    {
        npc = npc1;
    }
    void Start()
    {
            DialogManager.Instance.OnShowDialog += () =>
            {
                state = GameState.Dialog;
            };

            DialogManager.Instance.OnCloseDialog += () =>
            {
                if (state == GameState.Dialog)
                    state = GameState.FreeRoam;
            };
    }
    
    // Update is called once per frame
    private void Update()
    {
            if (state == GameState.FreeRoam)
            {
                playerController.HandleUpdate();
            }

            else if (state == GameState.Dialog)
            {
                DialogManager.Instance.HandleUpdate();
            }
    }
    
}
