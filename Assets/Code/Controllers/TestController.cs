using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestController : MonoBehaviour
{
    [SerializeField]
    private InFrameManager frame;

    private int count = 0;

    private void Awake()
    {
        frame.Initialize();
        frame.SetPassthrough();
    }

    private void Start()
    {
        frame.SetData($"<p style=\"color: white;\">{count} times clicked!</p>");
    }

    public void OnClick()
    {
        count++;
        frame.SetData($"<p style=\"color: white;\">{count} times clicked!</p>");
    }
}
