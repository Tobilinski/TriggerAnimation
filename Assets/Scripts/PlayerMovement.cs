using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator anim;
    public Animator peachanim;
    private float timeDis = 3f;
    // This is the player's speed
    public float speed = 5f;
    public GameObject Text;
    private void Awake()
    {
        Text.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

        // Dev debug tools
        /*if (Input.GetKey(KeyCode.Space))
        {
            peachanim.SetBool("IsSurp", true);
            
        }*/




        // Get the horizontal input from the player
        float horiz = Input.GetAxis("Horizontal");
        
        // Move the player at the same speed left or right
        transform.position += Vector3.right * horiz * speed * Time.deltaTime;

           // If the player is moving horizontally
       if(Mathf.Abs(horiz) > 0)
        {
            // Play the run animation
            anim.SetBool("IsWalking", true);
        }
        // Otherwise
        else
        {
            // Play the idle animation
            anim.SetBool("IsWalking", false);

        }





             // This code flips the character
        if (horiz < 0)
        {
            transform.localScale = new Vector3(-0.61f, 0.61f, 0.61f);
        }
        else if (horiz > 0)
        {
            transform.localScale = new Vector3(0.61f, 0.61f, 0.61f);
        }
    }
    //Trigger detction and trigger of animation
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Trigger")
        {           
            peachanim.SetBool("IsSurp", true);
            //print("hit");
            Disable(timeDis);          
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Trigger")
        {
            Text.SetActive(false);
        }
    }
    //Disable script Function
    void Disable(float time)
    {
        enabled = false;
        anim.SetBool("IsWalking", false);
        Text.SetActive(true);
        CancelInvoke("Enable");
       
        Invoke("Enable", time);

    }

    void Enable()
    {
        enabled = true;
    }

}
