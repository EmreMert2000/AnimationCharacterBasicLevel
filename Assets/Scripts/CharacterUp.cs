using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterUp : MonoBehaviour
{
    public float speed =1.2f;
    private Rigidbody rb;
 
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal")*Time.deltaTime*speed;

        transform.Translate(new Vector3(horizontal,0, speed * Time.deltaTime));
     
    }
   
    public void Teleport()
    {
        gameObject.transform.position += new Vector3(0, 0, 1);
    }
   
}
