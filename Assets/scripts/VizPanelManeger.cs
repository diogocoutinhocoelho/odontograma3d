using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VizPanelManeger : MonoBehaviour
{
    private GameObject lado;
    private GameObject dente;
    private GameObject mesh_dente;
    private GameObject toggle;

    public void MostrarEsconderDente()
    {
       dente = EventSystem.current.currentSelectedGameObject;
       
       mesh_dente = GameObject.Find("md" + dente.name);
       if (dente.GetComponent<Toggle>().isOn)
       {
           mesh_dente.GetComponent<Renderer>().enabled = true;
       }
       else
       {
           mesh_dente.GetComponent<Renderer>().enabled = false;
       }
    }
    public void MostrarArcada(string parte)
    {
        lado = GameObject.Find(parte);
        foreach (Transform child in lado.transform)
        {
            if (child.GetComponent<Renderer>().enabled)
            {
                child.GetComponent<Renderer>().enabled = false;
            }
            else
            {
                child.GetComponent<Renderer>().enabled = true;
            }
        }
    }

    private void Update()
    {
        
    }
}
