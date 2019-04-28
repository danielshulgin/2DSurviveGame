using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowController : MonoBehaviour
{
    public static FlowController instance;
    public static InputManager input = new InputManager();

    private void Awake()
    {
        instance = this;    
    }

}
