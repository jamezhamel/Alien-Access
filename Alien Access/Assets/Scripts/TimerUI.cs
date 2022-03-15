using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerUI : MonoBehaviour
{ 
    
    
    private Text _txtTimer;
    // Start is called before the first frame update
    void Awake()
    {
        _txtTimer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _txtTimer.text = Time.time.ToString("F2"); 
    }
}
