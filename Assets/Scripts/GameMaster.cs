using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{

    public GameObject timeDisplay;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string timeUS = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy   hh:mm tt");
        timeDisplay.GetComponent<Text>().text = timeUS;
    }
}
