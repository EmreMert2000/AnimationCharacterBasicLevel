using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    public CharacterUp character;
  
    private void Start()
    {
        anim = GetComponent<Animator>();
       
    }
    private void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            anim.SetTrigger("Walk");
            
        }
        else if (Input.GetButtonUp("Horizontal"))
        {
            anim.SetTrigger("Walk");
        }
        
        else if (Input.GetMouseButton(0))
        {
            anim.SetTrigger("Attack");
           
        }
        else if (Input.GetMouseButtonUp(0))
        {
            anim.SetTrigger("Walk");
        }
        else if (Input.GetMouseButton(1))
        {
            character.Teleport();
        }
      
    }

}
