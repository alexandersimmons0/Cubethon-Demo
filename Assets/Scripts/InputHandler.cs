using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Commands{
    public class InputHandler : MonoBehaviour{
        private Invoker _invoker;
        private bool isReplaying;
        private bool isRecording;
        private PlayerController controller;
        private Command buttonA, buttonD, buttonSpace, buttonLeftControl;
        void Start(){
            _invoker = gameObject.AddComponent<Invoker>();
            controller = FindObjectOfType<PlayerController>();
            isRecording = true;
            buttonA = new MoveLeft(controller);
            buttonD = new MoveRight(controller);
            //buttonSpace = new Jump(controller);
            //buttonLeftControl = new Duck(controller);
        }

        void Update(){
            if(!isReplaying && isRecording){
                if(Input.GetKey(KeyCode.A)){
                    _invoker.ExecuteCommand(buttonA);
                }
            }
            if(!isReplaying && isRecording){
                if(Input.GetKey(KeyCode.D)){
                    _invoker.ExecuteCommand(buttonD);
                }
            }
            /*if(!isReplaying && isRecording){
                if(Input.GetKey(KeyCode.Space)){
                    _invoker.ExecuteCommand(buttonSpace);
                }
            }
            if(!isReplaying && isRecording){
                if(Input.GetKey(KeyCode.LeftControl)){
                    _invoker.ExecuteCommand(buttonLeftControl);
                }
            }*/
        }
    }
}