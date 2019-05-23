using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameMaster : MonoBehaviour {

    public int points;

    public Text pointsText;

    private void Update()
    {
        pointsText.text = ("Points: " + points);

    }


}
