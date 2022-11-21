using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMoon : MonoBehaviour
{
    //rotation variables
    public float rotateSpeed;
    public Vector3 _rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotate();
    }
    //rotate keys
    private void rotate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rotation = Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _rotation = Vector3.back;
        }
        else
        {
            _rotation = Vector3.zero;
        }
        transform.Rotate(_rotation * rotateSpeed * Time.deltaTime);
    }
}
