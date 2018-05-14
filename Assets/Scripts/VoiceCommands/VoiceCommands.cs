using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceCommands : MonoBehaviour {
    public GameObject procedureScreen;
    public GameObject stepsScreen;

    void begin()
    {
        procedureScreen.SetActive(true);
    }

    void startProcedure()
    {
        if(procedureScreen.activeSelf)
        {
            procedureScreen.SetActive(false);
            stepsScreen.SetActive(true);
        }

    }

    void stopProcedure()
    {
        stepsScreen.SetActive(false);
    }


}
