using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;
using TMPro;

public class CounterController : MonoBehaviour
{
    public GameObject intInput;
    public GameObject stringInputs;
    CreatorService cService;


    // Start is called before the first frame update
    void Start()
    {
        cService = CreatorService.GetInstance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void prepareAction() {

        //ADDS INTEGER INPUT
        cService.actionPreparing.intInputs = new List<int>();
        if(!String.IsNullOrEmpty(intInput.GetComponent<TMP_InputField>().text)) {
            int i =  Int32.Parse(intInput.GetComponent<TMP_InputField>().text);
            cService.actionPreparing.intInputs.Add(i);
        }

        //ADDS STRING INPUT
        cService.actionPreparing.stringInputs = new List<String>();
        if(!String.IsNullOrEmpty(stringInputs.GetComponent<TMP_InputField>().text)) {
            cService.actionPreparing.stringInputs.Add(stringInputs.GetComponent<TMP_InputField>().text);
        }
    }

    public void resetPage(){
        try
        {
            intInput.GetComponent<TMP_InputField>().text = "";   
            stringInputs.GetComponent<TMP_InputField>().text = "";   
        }
        catch (System.Exception)
        {  
        }
    }
}
