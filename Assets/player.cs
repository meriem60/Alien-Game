using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 30;
    public string axe = "Vertical";
    void FixedUpdate(){
       float v = Input.GetAxisRaw(axe)*speed;
       GetComponent<Rigidbody2D>().velocity = new Vector2(0,v);
    }
}
