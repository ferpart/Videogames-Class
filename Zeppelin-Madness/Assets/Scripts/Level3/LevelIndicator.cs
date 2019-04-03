using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelIndicator : MonoBehaviour {

    public Image actualLevel;
    public Text level;
    public int number;

    private void Start()
    {
        if (actualLevel && level)
        {
            level.text = "Level: " + number;
            actualLevel.rectTransform.localScale = new Vector3(1, 1, 1);
        }
        else return;
   
    }

    private void Update()
    {
        if (actualLevel && level)
        {
            level.text = "Level: " + number;
            actualLevel.rectTransform.localScale = new Vector3(1, 1, 1);
        }
        else return;
    }


}
