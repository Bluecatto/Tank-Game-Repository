using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int player1Score = 0;
    public int player2Score = 0;
    public Text p1Text;
    public Text p2Text;

    public void Addp1Score()
    {
        player1Score++;
        p1Text.text = player1Score.ToString();
    }

    public void Addp2Score()
    {
        player2Score++;
        p2Text.text = player2Score.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
