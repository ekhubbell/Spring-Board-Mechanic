using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countDown : MonoBehaviour
{
    public static event Action TimesUp = delegate { };
    public float totalTime;
    public float remainingTime;
    public Image fillBar;

    void Start()
    {
        remainingTime = totalTime;
    }

    void Update()
    {
        fillBar.fillAmount = remainingTime / totalTime;
        remainingTime -= Time.deltaTime;
        if(remainingTime<=0f)
        {
            remainingTime = totalTime;
            TimesUp();
        }
    }
}
