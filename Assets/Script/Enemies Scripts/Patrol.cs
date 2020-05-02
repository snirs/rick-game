using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [Range(1,5)]
    [SerializeField]
    private float speed;

    private bool moveRight = true;

    public Transform groundDetection;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position,Vector2.down,2f);
        if (groundInfo.collider == false){
            if (moveRight){
                transform.eulerAngles = new Vector3(0,-180,0);
                moveRight = false;
            }
            else {
                transform.eulerAngles = new Vector3(0,0,0);
                moveRight = true;
            }
        }
    }
}
