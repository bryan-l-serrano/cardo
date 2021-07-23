using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIController : MonoBehaviour
{
    public GameObject flagCreator;
    public GameObject actionCreator;
    public GameObject cardCreator;
    public GameObject menuNav;

    bool menuActive = false;
    void Start() {
        // this.flagCreatorGUI = GetComponentInChildren<FlagCreatorGUI>(true);
        // this.flagCreatorGUI.TurnOnOffPage(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void navigateToCardCreatorPage(){
        cardCreator.SetActive(true);
        flagCreator.SetActive(false);
        actionCreator.SetActive(false);
    }
    public void navigateToActionCreatorPage(){
        cardCreator.SetActive(false);
        flagCreator.SetActive(false);
        actionCreator.SetActive(true);
    }
    public void navigateToFlagCreatorPage(){
        cardCreator.SetActive(false);
        flagCreator.SetActive(true);
        actionCreator.SetActive(false);
    }

    public void openMenu(){
        try
        {
            menuActive = !menuActive;
            menuNav.SetActive(menuActive);
        }
        catch (System.Exception)
        {            
        }

    }
}
