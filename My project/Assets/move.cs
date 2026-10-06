using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float movespeed;
    public float jumphight;
    public KeyCode spacebar;
    public KeyCode L;
    public KeyCode R;
    public Transform groundcheck;
    public float groundcheckradius;
    public LayerMask whatisground;
    private bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(spacebar) && grounded)
        {
            jump();
        }
        if (Input.GetKey(L))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed, GetComponent<Rigidbody2D>().velocity.y);
            if(GetComponent<SpriteRenderer>()!=null){
                GetComponent<SpriteRenderer>().flipX = true;
            }
        }
        if(Input.GetKey(R)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, GetComponent<Rigidbody2D>().velocity.y);
            if(GetComponent<SpriteRenderer>() !=null){
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }

        void jump()
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumphight);
        }
        
    }

    void FixedUpdate()
        {
            grounded = Physics2D.OverlapCircle(groundcheck.position, groundcheckradius, whatisground);

        }
}
