using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public string scene;
    public Vector2 playerPosition;
    public VectorValue playerStorage;
    Vector2 startPos = new Vector2(-7.5f, 0.8f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //public Vector2 playerPosition = new Vector2 (0.0f,0.0f);
    
    //public VectorValue playerStorage;

    public void EscenaJugar()
    {
        
        SceneManager.LoadScene("Casa_Scene1");
        playerStorage.initialValue = playerPosition;
        SceneManager.LoadScene(scene);

    }

    public void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void Salir()
    {
        Application.Quit();
    }

}
