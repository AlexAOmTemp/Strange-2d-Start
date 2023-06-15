using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackScreen : MonoBehaviour
{
    //public static BlackScreen Controller 
    private static GameObject _canvas;
    private static GameObject _blackScreen;

    private void Awake()
    {
        if (_canvas == null)
        {
            _canvas = this.gameObject;
            _blackScreen = transform.Find("BlackScreen").gameObject;
            _blackScreen.SetActive(false);
        }
        else
            Destroy(this.gameObject);
    }
    public static void ActivateBlackScreen(bool Active)
    {
        _blackScreen.SetActive(Active);
    }

}
