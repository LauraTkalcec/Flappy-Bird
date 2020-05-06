﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Generiraj : MonoBehaviour
{
    public GameObject stjene;
    int rezultat = 0;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("KreirajStjene", 1f, 1.5f);
	}
    void OnBUI()
    {
        GUI.color = Color.black;
        GUILayer.Label("Rezultat:" + rezultat.ToString());
    }
    void KreirajStjene()
    {
        Instantiate(stjene);
        rezultat++;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Instantiate(stjene);
	}
}
