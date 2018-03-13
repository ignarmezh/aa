using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int pinCount;

    public Text text;

    private void Start()
    {
        pinCount = 0;
    }

    private void Update()
    {
        text.text = pinCount.ToString();
    }
}
