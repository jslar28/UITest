using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public GameObject text;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bool state = text.gameObject.activeInHierarchy;
            text.gameObject.SetActive(!state);
        }
    }
}
