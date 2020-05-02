using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;

    public Transform groundDetection;

    private bool moveright = true;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position,Vector2.down,2f);
        if (groundInfo.collider == false){
            if (moveright){
                transform.eulerAngles = new Vector3(0,-180,0);
                moveright = false;
            }
            else {
                transform.eulerAngles = new Vector3(0,0,0);
                moveright = true;
            }
        }
    }
}
