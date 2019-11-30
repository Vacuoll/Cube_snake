﻿using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Buttons
{
    public class Home : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
