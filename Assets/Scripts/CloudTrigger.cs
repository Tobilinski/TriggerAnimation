using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudTrigger : MonoBehaviour
{
    public Animator Cloud1;
    public Animator Cloud2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Cloud1.SetBool("isCloud1", true);
            Cloud2.SetBool("isCloud2", true);
        }
    }
}
