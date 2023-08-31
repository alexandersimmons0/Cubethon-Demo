using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public Transform player;
    private float adjust;
    public Text score;

    void Update(){
        adjust = player.position.z + 10;
        score.text = adjust.ToString("0");
    }
}
