﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCommand : MonoBehaviour {
    public Button button;

    // Use this for initialization
    void Start()
    {

    }

    void Menu()
    {
        button.onClick.Invoke();
    }
}
