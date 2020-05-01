
using UnityEngine;
using System.Collections;

public class animControl : MonoBehaviour {

   public Animator anim;

 // Use this for initialization
 void Start () {
        anim = GetComponent<Animator>();
 }
 
 // Update is called once per frame
 void Update () {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow) )
        {
            anim.Play("rick_animation");
        }
         if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.Play("New State");
        }
}
   
}