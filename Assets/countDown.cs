using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countDown : MonoBehaviour
{
    public static event Action<int> TimesUp = delegate { };
    public float totalTime;
    public float remainingTime;

    // Start is called before the first frame update
    void Start()
    {
        remainingTime = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime -= Time.deltaTime;
        if(remainingTime<=0f)
        {
            remainingTime = totalTime;
            TimesUp(0);
        }
    }
}
