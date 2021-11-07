using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneTransition : MonoBehaviour
{
    public string scene;
    public Vector2 playerPosition;
    public VectorValue playerStorage;
    Vector2 startPos=new Vector2(-7.5f,0.8f);

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && !collision.isTrigger)
        {
            playerStorage.initialValue = playerPosition;
            SceneManager.LoadScene(scene);
        }
    }
}
