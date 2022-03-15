using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserPrompt : MonoBehaviour

{
    const string DBTAG = "Dialogbox";
    
    [SerializeField] string _title, _message;
    [SerializeField] float _timer = 0;

    INotifier _dialogbox;



    private void Awake()
    {
        _dialogbox = GameObject.FindWithTag(DBTAG).GetComponent<INotifier>();

    }
    private void OnMouseDown()
    {
        _dialogbox.Notify(_title, _message, _timer);
    }

}