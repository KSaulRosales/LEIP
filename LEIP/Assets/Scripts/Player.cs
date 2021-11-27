using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 4f;
    Animator anim;
    Rigidbody2D rb2d;
    Vector2 mov;
    public VectorValue startingPosition;
    public LayerMask interactableLayer;
    public LayerMask solidObjectsLayer;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        transform.position = startingPosition.initialValue;
    }
    
    // Update is called once per frame
    public void HandleUpdate()
    {
        if (!PauseMenu.GameIsPaused)
        {
            //Dectectamos el movimiento en un vector
             mov = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
            );
       
           if (mov != Vector2.zero)
           {
            anim.SetFloat("MovX", mov.x);
            anim.SetFloat("MovY", mov.y);
            anim.SetBool("Walking", true);
           }
           else
           {
            anim.SetBool("Walking", false);
           }

        }
        if (Input.GetKeyDown(KeyCode.J))
            Interact();
    }
    
    
        
    void Interact()
    {
        var facingDir = new Vector3(anim.GetFloat("MovX"), anim.GetFloat("MovY"));
        var interactPos = transform.position + facingDir;

        //Debug.DrawLine(transform.position, interactPos, Color.blue, 0.5f);
        var collider = Physics2D.OverlapCircle(interactPos, 0.3f, interactableLayer);
        if (collider != null)
        {
            collider.GetComponent<Interactable>()?.Interact();
        }
        
    }
   
    private void FixedUpdate()
    {
        //Nos movemos en el fixed por las físicas
        rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
    }
}
