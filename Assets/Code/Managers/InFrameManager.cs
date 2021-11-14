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

    private string foo = "foo";

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
        //SetURL("https://www.openstreetmap.org/export/embed.html?bbox=-0.004017949104309083%2C51.47612752641776%2C0.00030577182769775396%2C51.478569861898606&layer=mapnik");
        SetData($"<body>{foo}</body>");
        SetPassthrough();
    }

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

    public void SetURL(string url)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        SetURLInternal(url);
#endif
    }
}
