using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class DataManager : MonoBehaviour
{
    private Transform nome;
    private Transform raiz;
    private Transform coroa;
    private Transform faceD;
    private Transform faceO;
    private Transform faceM;
    private Transform faceL;
    private Transform faceV;
    private Transform btnSave;
    private string path;
    private DataStructure newData;
    void Start()
    {
        btnSave = gameObject.transform.Find("btnSave");
        btnSave.GetComponent<Button>().onClick.AddListener(saveData);
        raiz = gameObject.transform.Find("Raiz");
        coroa = gameObject.transform.Find("Coroa");
        faceO = gameObject.transform.Find("FaceO");
        faceM = gameObject.transform.Find("FaceM");
        faceD = gameObject.transform.Find("FaceD");
        faceV = gameObject.transform.Find("FaceV");
        faceL = gameObject.transform.Find("FaceL");
        nome = gameObject.transform.Find("TothName");
    }

    void saveData()
    {
        path = Path.Combine(Application.dataPath, $"json/{nome.GetComponent<Text>().text}.json");
        if (File.Exists(path))
        {
            print("JA TEM");
        }
        else
        {
            newData = new DataStructure();
            newData.raiz = raiz.GetComponent<Dropdown>().value;
            newData.coroa = coroa.GetComponent<Dropdown>().value;
            newData.faceL = faceL.GetComponent<Dropdown>().value;
            newData.faceD = faceD.GetComponent<Dropdown>().value;
            newData.faceM = faceM.GetComponent<Dropdown>().value;
            newData.faceV = faceV.GetComponent<Dropdown>().value;
            newData.faceO = faceO.GetComponent<Dropdown>().value;
            string jsonString = JsonUtility.ToJson(newData);
            File.WriteAllText(path, jsonString);
            gameObject.SetActive(false);

        }
    }    
    
}

public class DataStructure
{
    public int raiz;
    public int coroa;
    public int faceM;
    public int faceO;
    public int faceV;
    public int faceD;
    public int faceL;
}