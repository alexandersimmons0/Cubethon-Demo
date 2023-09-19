using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Commands{
    public class Invoker : MonoBehaviour
    {
        private bool isRecording;
        private bool isReplaying;
        private float replayTime;
        private float recordingTime;
        private SortedList<float, Command> _recordedCommands = new SortedList<float, Command>();

        public void ExecuteCommand(Command command){
            command.Execute();
            if(isRecording){
                Debug.Log("Command Entered: " + command);
                _recordedCommands.Add(recordingTime, command);
            }
        }

        public void Start(){
            Record();
        }

        public void Record(){
            recordingTime = 0.0f;
            isRecording = true;
        }

        public void Replay(){
            replayTime = 0.0f;
            isReplaying = true;
            _recordedCommands.Reverse();
        }

        public void WinGame(){
            Replay();
        }

        void Update(){
            if(isRecording){
                recordingTime += Time.deltaTime;
            }
            if(isReplaying){
                replayTime += Time.deltaTime;
                if(_recordedCommands.Any()){
                    if(Mathf.Approximately(replayTime, _recordedCommands.Keys[0])){
                        _recordedCommands.Values[0].Execute();
                        _recordedCommands.RemoveAt(0);
                    }
                }else{
                    GameObject.Find("_GameManager").GetComponent<GameManager>().WinGame();
                    isReplaying = false;
                }
            }
        }

    }
}