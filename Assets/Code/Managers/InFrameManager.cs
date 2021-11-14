#if UNITY_WEBGL && !UNITY_EDITOR
using System.Runtime.InteropServices;
#endif
using UnityEngine;

public class InFrameManager : MonoBehaviour
{
#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void InitializeInternal();

    [DllImport("__Internal")]
    private static extern void SetPassthroughInternal();

    [DllImport("__Internal")]
    private static extern void SetDataInternal(string str);

    [DllImport("__Internal")]
    private static extern void SetURLInternal(string str);
#endif

    public void Initialize()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        InitializeInternal();
#endif
    }

    public void SetPassthrough()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        SetPassthroughInternal();
#endif
    }

    public void SetData(string data)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        SetDataInternal(data);
#endif
    }

    public void SetTemplate(TextAsset asset)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        SetDataInternal(asset.text);
#endif
    }

    public void SetURL(string url)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        SetURLInternal(url);
#endif
    }
}
