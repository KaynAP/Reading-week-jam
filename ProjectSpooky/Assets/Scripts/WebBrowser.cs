using UnityEngine;
using TMPro;
using NUnit.Framework;
using System.Collections.Generic;
using System;

public class WebBrowser : MonoBehaviour
{
    public TMP_InputField urlField;
    public List<URLData> urls = new List<URLData>();
    private Dictionary<string, GameObject> urlDictionary;


    private void Start()
    {
        InitializeDictionary();
    }
    public void InitializeDictionary()
    {
        urlDictionary = new Dictionary<string, GameObject>();
        foreach(URLData url in urls)
        {
            urlDictionary.Add(url.url, url.window);
        }
    }
    public void OpenWebpage()
    {
        if (urlDictionary.ContainsKey(urlField.text))
        {
            urlDictionary[urlField.text].SetActive(true);
        }
    }
}

[Serializable]
public class URLData
{
    public string url;
    public GameObject window;
}