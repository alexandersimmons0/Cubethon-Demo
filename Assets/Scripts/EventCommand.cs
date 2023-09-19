using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command{
    public abstract void Execute();
}

namespace Commands{
    public class MoveLeft : Command{
        private PlayerController _controller;

        public MoveLeft(PlayerController controller){
            _controller = controller;
        }

        public override void Execute(){
            _controller.TurnLeft();
        }
    }

    public class MoveRight : Command{
        private PlayerController _controller;

        public MoveRight(PlayerController controller){
            _controller = controller;
        }

        public override void Execute(){
            _controller.TurnRight();
        }
    }

    public class Jump : Command{
        private PlayerController _controller;

        public Jump(PlayerController controller){
            _controller = controller;
        }

        public override void Execute(){
            _controller.TryJump();
        }
    }

    public class Duck : Command{
        private PlayerController _controller;

        public Duck(PlayerController controller){
            _controller= controller;
        }

        public override void Execute(){
            _controller.TryDuck();
        }
    }
}