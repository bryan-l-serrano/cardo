using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class UseAbilityController : MonoBehaviour
{
    public MultiSelect cardToggle;
    public Toggle useStoredDeck;

    CreatorService creatorService;

    // Start is called before the first frame update
    void Start()
    {
        creatorService = CreatorService.GetInstance;

        cardToggle.stringList = creatorService.cards;
        cardToggle.loadToggles();

    }

    public void prepareAction() {
        if(!useStoredDeck.isOn){
            //ADDS card inputs
            creatorService.actionPreparing.cardNameInputs = cardToggle.getSelectedOptions();
        }
    }

    public void resetPage(){
        try
        {
            cardToggle.resetToggles(); 
            useStoredDeck.isOn = false;
        }
        catch (System.Exception)
        {  
        }
    }
}
