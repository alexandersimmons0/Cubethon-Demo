using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rigid;
    public float forwardForce;
    public float horizontalForce;
    void Start(){
        
    }

    void Update(){

    }

    void FixedUpdate(){
        rigid.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(Input.GetKey(KeyCode.D)){
            rigid.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.A)){
            rigid.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rigid.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
