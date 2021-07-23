using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;
using TMPro;

public class TransferActionController : MonoBehaviour
{
    public GameObject deck1DD;
    public GameObject deck2DD;

    CreatorService cService;
    Action action;


    // Start is called before the first frame update
    void Start()
    {
        cService = CreatorService.GetInstance;
        populateDropdowns();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void prepareAction() {
        this.action = ScriptableObject.CreateInstance<Action>() as Action;

        //ADDS DECK 1 INPUT
        string deck1 = cService.getDropdownValue(deck1DD, "GameStateDecks");
        action.gameStateDeckInputs = new List<GameStateDecks>();
        if(deck1 != null) {
            action.gameStateDeckInputs.Add((GameStateDecks) Enum.Parse(typeof(GameStateDecks), deck1));
        }
        //ADDS DECK 2 INPUT
        string deck2 = cService.getDropdownValue(deck2DD, "GameStateDecks");
        if(deck2 != null) {
            action.gameStateDeckInputs.Add((GameStateDecks) Enum.Parse(typeof(GameStateDecks), deck2));
        }

        cService.actionPreparing = action;

    }

    public void populateDropdowns() {

        this.cService.addDropdownItems(deck1DD, "GameStateDecks");
        this.cService.addDropdownItems(deck2DD, "GameStateDecks");

    }

    public void resetPage(){
        try
        {
            cService.resetDropdownValue(deck1DD);
            cService.resetDropdownValue(deck2DD);   
        }
        catch (System.Exception)
        {  
        }
    }
}
