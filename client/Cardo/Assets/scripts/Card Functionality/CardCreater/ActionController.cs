using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActionController : MonoBehaviour
{
    public GameObject TRANSFER_PAGE;
    public GameObject DRAW_PAGE;
    public GameObject SELECT_PAGE;
    public GameObject COUNTER_PAGE;
    public GameObject FLAG_PAGE;
    public GameObject USE_ABILITY_PAGE;
    public GameObject actionDD;

    public void setPage() {
        int dropdownValue = actionDD.GetComponent<TMP_Dropdown>().value;
        switch (dropdownValue)
        {
            case 1:
                this.transferDecksPage();
                break;
            case 2:
                this.drawPage();
                break;
            case 3:
                this.selectPage();
                break;
            case 4:
                this.counterChangePage();
                break;
            case 5:
            case 6:
            case 7:
                this.setFlagsPage();
                break;
            case 8:
                this.setUseAbilitiesPage();
                break;
            case 9:
            default:
                this.startPage();
                break;
        }
    }

    private void transferDecksPage() {
        TRANSFER_PAGE.SetActive(true);
        TRANSFER_PAGE.GetComponent<TransferActionController>().resetPage();

        DRAW_PAGE.SetActive(false);
        SELECT_PAGE.SetActive(false);
        COUNTER_PAGE.SetActive(false);
        FLAG_PAGE.SetActive(false);
        USE_ABILITY_PAGE.SetActive(false);
    }

    private void drawPage() {
        DRAW_PAGE.SetActive(true);
        DRAW_PAGE.GetComponent<DrawController>().resetPage();

        TRANSFER_PAGE.SetActive(false);
        SELECT_PAGE.SetActive(false);
        COUNTER_PAGE.SetActive(false);
        FLAG_PAGE.SetActive(false);
        USE_ABILITY_PAGE.SetActive(false);
    }

    private void selectPage() {
        SELECT_PAGE.SetActive(true);
        SELECT_PAGE.GetComponent<SelectController>().resetPage();

        TRANSFER_PAGE.SetActive(false);
        DRAW_PAGE.SetActive(false);
        COUNTER_PAGE.SetActive(false);
        FLAG_PAGE.SetActive(false);
        USE_ABILITY_PAGE.SetActive(false);
    }

    private void counterChangePage() {
        COUNTER_PAGE.SetActive(true);
        COUNTER_PAGE.GetComponent<CounterController>().resetPage();

        TRANSFER_PAGE.SetActive(false);
        DRAW_PAGE.SetActive(false);
        SELECT_PAGE.SetActive(false);
        FLAG_PAGE.SetActive(false);
        USE_ABILITY_PAGE.SetActive(false);
    }

    private void setFlagsPage() {
        FLAG_PAGE.SetActive(true);
        FLAG_PAGE.GetComponent<FlagController>().resetPage();

        TRANSFER_PAGE.SetActive(false);
        DRAW_PAGE.SetActive(false);
        SELECT_PAGE.SetActive(false);
        COUNTER_PAGE.SetActive(false);
        USE_ABILITY_PAGE.SetActive(false);
    }

    private void setUseAbilitiesPage(){
        USE_ABILITY_PAGE.SetActive(true);
        USE_ABILITY_PAGE.GetComponent<UseAbilityController>().resetPage();

        TRANSFER_PAGE.SetActive(false);
        DRAW_PAGE.SetActive(false);
        SELECT_PAGE.SetActive(false);
        COUNTER_PAGE.SetActive(false);
        FLAG_PAGE.SetActive(false);
    }
    public void startPage() {
        TRANSFER_PAGE.SetActive(false);
        DRAW_PAGE.SetActive(false);
        SELECT_PAGE.SetActive(false);
        COUNTER_PAGE.SetActive(false);
        FLAG_PAGE.SetActive(false);
        USE_ABILITY_PAGE.SetActive(false);
    }
}
