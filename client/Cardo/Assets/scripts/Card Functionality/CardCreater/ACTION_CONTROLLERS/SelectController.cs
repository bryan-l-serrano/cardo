using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;
using TMPro;

public class SelectController : MonoBehaviour
{
    public GameObject intInput;
    public MultiSelect flagSelect;
    public FlagsScriptable flagList;
    CreatorService cService;


    // Start is called before the first frame update
    void Start()
    {
        cService = CreatorService.GetInstance;

        flagSelect.stringList = flagList.flags;
        flagSelect.loadToggles();
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

        //ADDS FLAG INPUTs
            cService.actionPreparing.cardFlagInputs = flagSelect.getSelectedOptions();

    }

    public void resetPage(){
        try
        {
            flagSelect.resetToggles();
            intInput.GetComponent<TMP_InputField>().text = "";   
        }
        catch (System.Exception)
        {  
        }
    }

}
