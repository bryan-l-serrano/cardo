using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class ActionCreatorGUI : MonoBehaviour
{
    public GameObject actionName;
    public GameObject title;
    public GameObject actionDescription;
    public GameObject actionDropdown;
    public GameObject opponentActionToggle;
    public GameObject blockableActionToggle;
    public MultiSelect blockCardSelect;
    public GameObject submitActionButton;

    //Action Controllers********************
    public CounterController counterController;
    public DrawController drawController;
    public FlagController flagController;
    public SelectController selectController;
    public TransferActionController transferActionController;
    public UseAbilityController useAbilityController;
    //**************************************

    CreatorService cService;

    Action action;

    // Start is called before the first frame update
    void Start()
    {
        cService = CreatorService.GetInstance;
        this.action = ScriptableObject.CreateInstance<Action>() as Action;

        this.populateDropdowns();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createAction() {
        this.prepareAction();
        string name = actionName.GetComponent<TMP_InputField>().text;
        cService.createAction(name);
        actionDropdown.GetComponent<TMP_Dropdown>().value = 0;
    }

    public void prepareAction() {
        cService.setAction();

        //ADDS ACTIONTYPE INPUT
        string actionValue = cService.getDropdownValue(actionDropdown, "ActionType");
        ActionType actionType = (ActionType) Enum.Parse(typeof(ActionType), actionValue);
        if(actionValue != null) {
            cService.actionPreparing.actionType = actionType;
        }

        //ADDS BLOCK CARD INPUTs
        cService.actionPreparing.cardsThatOpponentCanPlayThatBlockAction = blockCardSelect.getSelectedOptions();

        //ADDS OPPONENT ACTION
        cService.actionPreparing.opponentAction = opponentActionToggle.GetComponent<Toggle>().isOn;

        //PREPARE CONTROLLER ACTIONS
        this.prepareControllerActions(actionType);
    }

    private void prepareControllerActions(ActionType actionValue){
        switch (actionValue)
        {
            case ActionType.COUNTER_CHANGE:
                counterController.prepareAction();
                break;
            case ActionType.DRAW:
                drawController.prepareAction();
                break;
            case ActionType.SELECT:
                selectController.prepareAction();
                break;
            case ActionType.TRANSFER:
                transferActionController.prepareAction();
                break;
            case ActionType.SET_FLAGS:
            case ActionType.REMOVE_FLAGS:
            case ActionType.STORE_DECK:
                flagController.prepareAction();
                break;
            case ActionType.USE_CARD_ABILITY:
                useAbilityController.prepareAction();
                break;
            case ActionType.END_TURN:
            default:
                break;
        }
    }

    public void populateDropdowns() {
        this.cService.addDropdownItems(actionDropdown, "ActionType");
    }

}
