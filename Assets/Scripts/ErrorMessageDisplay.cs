using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorMessageDisplay : MonoBehaviour
{
    public Text msgTxt;
    public Button dismissBtn;

    public void DisplayMessage(string msgToShow,UnityEngine.Events.UnityAction actionOnDismiss)
    {
        msgTxt.text = msgToShow;
        dismissBtn.onClick.AddListener(actionOnDismiss);
    }
}
