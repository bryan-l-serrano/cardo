using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlagCreatorGUI : MonoBehaviour
{
    public FlagsScriptable flagList;

    public GameObject flagsDisplayComponent;
    TextMeshProUGUI flagsText;

    public GameObject inputField;

    // Start is called before the first frame update
    void Start()
    {
        flagsText = flagsDisplayComponent.GetComponent<TextMeshProUGUI>();

        foreach (var flag in flagList.flags)
        {
            flagsText.text += "\n" + flag;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddFlag() {
        string text = inputField.GetComponent<TMP_InputField>().text;
        flagList.flags.Add(text);
        flagsText.text += "\n" + text;
    }

    public void RemoveFlag() {
        string text = inputField.GetComponent<TMP_InputField>().text;
        flagList.flags.Remove(text);
        this.RefreshFlagList();
    }

    public void TurnOnOffPage(bool isOn) {
        gameObject.SetActive(isOn);
    }

    public void RefreshFlagList(){
        flagsText.text = "Flag List";
        foreach (var flag in flagList.flags)
        {
            flagsText.text += "\n" + flag;
        }
    }

}
