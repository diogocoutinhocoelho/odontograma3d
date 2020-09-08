using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ToothPanelManager : MonoBehaviour
{
    private GameObject dente;
    public GameObject panel;
    private GameObject panelName;
    private bool saveJson;
    private string path;
    private Data newData;
    private void Start()
    {
        path = Path.Combine(Application.dataPath, $"json/{gameObject.name}.json");
        newData = new Data();
    }

    private void Update()
    {
        if (File.Exists(path))
        {
            gameObject.transform.Find("coroaStatus").gameObject.SetActive(true);
        }
        else
        {
            gameObject.transform.Find("coroaStatus").gameObject.SetActive(false);

        }
    }

    private void OnMouseEnter()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.gray;
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    void OnMouseDown()
    {
        saveJson = File.Exists(path);
        panel.SetActive(true);
        panelName = GameObject.Find("TothName");
        panelName.GetComponent<Text>().text = gameObject.name;
        
        if (saveJson)
        {
            string json = File.ReadAllText(path);
            JsonUtility.FromJsonOverwrite(json, newData);
            panel.transform.Find("Raiz").GetComponent<Dropdown>().value = newData.raiz;
            panel.transform.Find("Coroa").GetComponent<Dropdown>().value = newData.coroa;
            panel.transform.Find("FaceM").GetComponent<Dropdown>().value = newData.faceM;
            panel.transform.Find("FaceO").GetComponent<Dropdown>().value = newData.faceO;
            panel.transform.Find("FaceL").GetComponent<Dropdown>().value = newData.faceL;
            panel.transform.Find("FaceD").GetComponent<Dropdown>().value = newData.faceD;
            panel.transform.Find("FaceV").GetComponent<Dropdown>().value = newData.faceV;
        }
        else
        {
            panel.transform.Find("Raiz").GetComponent<Dropdown>().value = 0;
            panel.transform.Find("Coroa").GetComponent<Dropdown>().value = 0;
            panel.transform.Find("FaceM").GetComponent<Dropdown>().value = 0;
            panel.transform.Find("FaceO").GetComponent<Dropdown>().value = 0;
            panel.transform.Find("FaceL").GetComponent<Dropdown>().value = 0;
            panel.transform.Find("FaceD").GetComponent<Dropdown>().value = 0;
            panel.transform.Find("FaceV").GetComponent<Dropdown>().value = 0;
        }
        
    }
}
public class Data
{
    public int raiz;
    public int coroa;
    public int faceM;
    public int faceO;
    public int faceV;
    public int faceD;
    public int faceL;
}