using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Commands{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody rigid;
        private  float forwardForce = 4000f;
        private float horizontalForce = 100f;
        private float verticalForce = 6.5f;

        void Start(){
            rigid = GetComponent<Rigidbody>();
        }

        void FixedUpdate(){
            rigid.AddForce(0, 0, forwardForce * Time.deltaTime);
            if(rigid.position.y < -1f){
                FindObjectOfType<GameManager>().EndGame();
            }
        }

        public void ResetPosition(){
            transform.position = new Vector3(0f, 1f, -10f);
            rigid.AddForce(0,0,0);
        }

        public void TurnLeft(){
            rigid.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        public void TurnRight(){
                rigid.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        public void TryJump(){
            if(Input.GetKeyDown(KeyCode.Space) && !Input.GetKey(KeyCode.LeftControl) && Physics.Raycast(rigid.transform.position, Vector3.down, 0.5f)){
                rigid.AddForce(0, verticalForce, 0, ForceMode.Impulse);
            }
        }
        public void TryDuck(){
            if(Input.GetKey(KeyCode.LeftControl)){
                rigid.transform.localScale = new Vector3(1f,0.5f,1f);
            }else{
                rigid.transform.localScale = new Vector3(1f,1f,1f);
            }        
        }
    }
}