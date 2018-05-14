using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseCommand : MonoBehaviour {
    public Button button;

    void CloseVitals()
    {
        button.onClick.Invoke();
    }
}
