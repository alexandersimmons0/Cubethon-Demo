using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Commands{
    public class PlayerCollision : MonoBehaviour
    {
        private InputHandler movement;

        void OnCollisionEnter(Collision collision){
            movement = GetComponent<InputHandler>();
            if(collision.collider.tag == "obsticle"){
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }       
}