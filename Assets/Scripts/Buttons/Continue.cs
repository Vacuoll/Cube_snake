﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Continue : MonoBehaviour, IPointerClickHandler
{
   public GameObject PanelPause;
    public GameObject Pause;
    public bool continuation = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        PanelPause.SetActive(false);
        Pause.SetActive(true);

        continuation = true;
    }
}
