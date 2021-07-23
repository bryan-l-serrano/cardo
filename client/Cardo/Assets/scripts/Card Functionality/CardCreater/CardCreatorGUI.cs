using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;
using TMPro;

public class CardCreatorGUI : MonoBehaviour{

    public FlagsScriptable flagList;

    public GameObject flagsDisplayComponent;
    TextMeshProUGUI flagsText;

    public GameObject dropdownObject;
    TMP_Dropdown dropdown;

    public GameObject cardName;
    public GameObject numCardsInDeck;
    
    List<string> cardFlags;
    CardScriptable newCard;
    CardAbilitySriptable ability;
    
    CreatorService cService;

    void Start() {
        cService = CreatorService.GetInstance;
        cardFlags = new List<string>();
        flagsText = flagsDisplayComponent.GetComponent<TextMeshProUGUI>();
        newCard = ScriptableObject.CreateInstance<CardScriptable>() as CardScriptable;
        ability = ScriptableObject.CreateInstance<CardAbilitySriptable>() as CardAbilitySriptable;

        dropdown = dropdownObject.GetComponent<TMP_Dropdown>();
        foreach (var flag in flagList.flags)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData(){text = flag});
        }
    }

    public void AddFlag(){
        if(dropdown.value != 0){
            cardFlags.Add(flagList.flags[dropdown.value-1]);
        }
        this.RefreshFlagList();
    }


    public void RefreshFlagList(){
        flagsText.text = "Flag List";
        foreach (var flag in cardFlags)
        {
            flagsText.text += "\n" + flag;
        }
    }

    public void createCard(){
        newCard.cardName = cardName.GetComponent<TMP_InputField>().text;
        int numbC = numCardsInDeck.GetComponent<TMP_InputField>().text.Length>0 ? Int32.Parse(numCardsInDeck.GetComponent<TMP_InputField>().text) : 0;
        newCard.numberOfCardsInDeck = numbC;
        newCard.flags = cardFlags;
        string path = "Assets/Resources/Cards/" + newCard.cardName;
        System.IO.Directory.CreateDirectory(path);
        AssetDatabase.CreateAsset(newCard, path + "/" + newCard.cardName + ".asset");
        AssetDatabase.CreateAsset(ability, path + "/" + newCard.cardName + "Ability.asset");
        AssetDatabase.SaveAssets();
        cService.activeCard = newCard.cardName;
    }

}