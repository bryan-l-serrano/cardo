using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MultiSelect : MonoBehaviour
{
    public int numberAllowedForSelection;
    public string enumType;
    public bool isEnum;
    public List<string> stringList;

    public GameObject toggleTemplate;
    public Vector3 startingPosition;

    CreatorService creatorService;
    List<Toggle> toggleList;
    int toggleIndex = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void loadToggles(){
        creatorService = CreatorService.GetInstance;
        List<string> enums;
        if(isEnum){
            enums = CreatorService.EnumValues(enumType);
        }
        else{
            enums = stringList;
        }
        toggleList = new List<Toggle>();
        
        for (int i = 0; i < enums.Count; i++)
        {
            string value = enums[i];
            GameObject toggleParent = new GameObject(value);
            toggleParent.transform.SetParent(this.transform);
            GameObject newToggleObject;
            newToggleObject = GameObject.Instantiate(toggleTemplate);
            newToggleObject.transform.SetParent(toggleParent.transform);
            newToggleObject.GetComponentInChildren<Text>().text = value;
            newToggleObject.GetComponentInChildren<Text>().color = new Color(255,255,255,255);

            Toggle mToggle = newToggleObject.GetComponentInChildren<Toggle>();
            mToggle.transform.position += new Vector3(0,-25*(i+1),0) + startingPosition;
            mToggle.isOn=false;
            mToggle.onValueChanged.AddListener(delegate {
                ToggleValueChanged(mToggle.isOn);
            });
            toggleList.Add(mToggle);
        }
    }

    private void ToggleValueChanged(bool value){
        if(toggleIndex == numberAllowedForSelection) {
            foreach (var tog in toggleList)
            {
                tog.interactable = true;
            }
        }

        if(value) {
            toggleIndex += 1;
        } else {
            toggleIndex -=1;
        }

        if(toggleIndex == numberAllowedForSelection) {
            foreach (var tog in toggleList)
            {
                if(tog.isOn == false)
                    tog.interactable = false;
            }
        }
    }


    public List<string> getSelectedOptions() {
        List<string> selectedTogs = new List<string>();
        foreach (var tog in toggleList)
        {
            if(tog.isOn){
                selectedTogs.Add(tog.GetComponentInChildren<Text>().text);
            }
        }
        return selectedTogs;
    }

    public void resetToggles(){
        try
        {
            foreach (var tog in toggleList)
            {
                tog.isOn = false;
            }
        }
        catch (System.Exception)
        {
        }
    }
}
