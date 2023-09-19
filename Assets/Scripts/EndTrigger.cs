using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Commands{
    public class EndTrigger : MonoBehaviour{ 
        private Invoker _invoker;  
        private PlayerController controller;
        private InputHandler handle;
        public GameObject replayText;
        void OnTriggerEnter(){ 
            _invoker = GameObject.Find("Player").GetComponent<Invoker>();
            controller = GameObject.Find("Player").GetComponent<PlayerController>();
            handle = GameObject.Find("Player").GetComponent<InputHandler>();
            handle.enabled = false;
            controller.ResetPosition();
            replayText.SetActive(true);
            _invoker.Replay();
        }
    }
}