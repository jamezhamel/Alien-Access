using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Dialogbox : MonoBehaviour, INotifier


{
    [SerializeField] Text _txtTitle, _txtMessage;
    [SerializeField] Button _okButton;

    private void Start()
    {
        Close();
        //gameObject.SetActive(false);
        //Notify("test the title", "this is a test message:");
    }

    public void Notify(string title, string message, float timer = 0)

    {
        _txtTitle.text = title;
        _txtMessage.text = message;
        gameObject.SetActive(true);

        if (timer > 0)
        {
            _okButton.gameObject.SetActive(false);
            Invoke(nameof(Close), timer);
        }
        else
        {
            _okButton.gameObject.SetActive(true);
        }
    }

    void Close()
    {
        gameObject.SetActive(false);
    }
}
