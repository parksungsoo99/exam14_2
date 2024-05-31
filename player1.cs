using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    
    new Rigidbody2D rigidbody;
    Animator animator;
    Vector2 velocity;
    public float speed = 1.0f;
    [SerializeField] GameObject bodyObject;

   void Awake(){
        rigidbody = GetComponent<Rigidbody2D>();
        animator = bodyObject.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        float _hozInput = Input.GetAxisRaw("Horizontal");
        
        velocity = new Vector2(_hozInput, 0).normalized * speed;

        if(velocity.x !=0){
            animator.SetBool("isWalk",true);
        }
        else{
            animator.SetBool("isWalk",false);
        }

        if(_hozInput > 0){
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        else if(_hozInput < 0 ){
            transform.rotation = Quaternion.Euler(0,180,0);
        }

    }
    
    void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(velocity.x, velocity.y);
    }
        
    
}
