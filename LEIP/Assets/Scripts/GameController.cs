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
   
    
    void Start()
    {
            DialogManagerV.Instance.OnShowDialog += () =>
            {
                state = GameState.Dialog;
            };

            DialogManagerV.Instance.OnCloseDialog += () =>
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
                DialogManagerV.Instance.HandleUpdate();
            }
    }
    
}
