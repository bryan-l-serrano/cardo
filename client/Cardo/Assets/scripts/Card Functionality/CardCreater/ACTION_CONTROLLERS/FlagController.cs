using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;
using TMPro;

public class FlagController : MonoBehaviour
{
    public MultiSelect flagToggle;
    public FlagsScriptable flagsScriptable;
    public MultiSelect cardToggle;
    public MultiSelect deckToggle;

    CreatorService creatorService;

    // Start is called before the first frame update
    void Start()
    {
        creatorService = CreatorService.GetInstance;

        flagToggle.stringList = flagsScriptable.flags;
        flagToggle.loadToggles();

        cardToggle.stringList = creatorService.cards;
        cardToggle.loadToggles();

        deckToggle.loadToggles();
    }

    public void prepareAction() {

        //ADDS flag inputs
        creatorService.actionPreparing.cardFlagInputs = flagToggle.getSelectedOptions();

        //ADDS deck inputs
         List<GameStateDecks> enumDecks = new List<GameStateDecks>();
        foreach (var deck in deckToggle.getSelectedOptions()) {
            enumDecks.Add((GameStateDecks)Enum.Parse(typeof(GameStateDecks), deck));
        }
        creatorService.actionPreparing.gameStateDeckInputs = enumDecks;

        //ADDS card inputs
        creatorService.actionPreparing.cardNameInputs = cardToggle.getSelectedOptions();

    }

    public void resetPage(){
        try
        {
            flagToggle.resetToggles();   
            cardToggle.resetToggles(); 
            deckToggle.resetToggles();  
        }
        catch (System.Exception)
        {  
        }
    }
}
