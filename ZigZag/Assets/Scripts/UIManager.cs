using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Animator TapTextAnimation;
    public Animator ZigZagPanelAnimation;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void StartGame()
    {
        TapTextAnimation.SetTrigger("call");
        ZigZagPanelAnimation.Play("New Animation");
    }

}
