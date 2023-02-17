using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//Simple UI Script for Button Logic
public class MenuFrame : MonoBehaviour
{
    [SerializeField] private TMP_Text header;
    [SerializeField] private TMP_Text numText;
    [SerializeField] private NumMeshCalculator calculator;
    
    public void Calculate()
    {
        int num = calculator.CalculateNumMeshes();
        numText.text = num.ToString();
    }


    public void ResetButton()
    {
        numText.text = "";
    }


    public void Quit()
    {
        Application.Quit();
    }
}
