using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ball : MonoBehaviour
{
    public float speed = 30;
    public Text scorerightText;
    public Text scoreleftText;
    int scoreRight;
    int scoreLeft;
    void Start(){
        GetComponent<Rigidbody2D>().velocity = Vector2.right*speed;
    }
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight){
        return(ballPos.y-racketPos.y)/racketHeight;
    }
    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name=="RacketRight"){
            float y = hitFactor(transform.position,col.transform.position,col.collider.bounds.size.y);
            Vector2 dir = new Vector2(1,y).normalized;
            GetComponent<Rigidbody2D>().velocity=dir*speed;
        }
         if(col.gameObject.name=="RacketLeft"){
            float y = hitFactor(transform.position,col.transform.position,col.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1,y).normalized;
            GetComponent<Rigidbody2D>().velocity=dir*speed;
        }
         if(col.gameObject.name == "wall-right"){
            scoreLeft ++;
            scoreleftText.text = scoreLeft.ToString();
        }   
        if(col.gameObject.name == "wall-left"){
            scoreRight ++;
            scorerightText.text = scoreRight.ToString();
        }  
    }
    
       
    
}
