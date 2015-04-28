using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeRemain : MonoBehaviour {

    public Image time;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        TimeRun();
	}

    void TimeRun()
    {
        time.fillAmount -= (float)1 / (float)60 * Time.deltaTime;
    }
}
