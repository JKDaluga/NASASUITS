using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueCommand : MonoBehaviour {
    public GameObject onboardScreen;

    void Continue()
    {
        onboardScreen.SetActive(false);
    }
}
