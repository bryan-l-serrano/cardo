using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;
using System.Linq;
using TMPro;

public class CreatorService
{
    //INSTANTIATES AS A SINGLETON*******************************************8
	private static CreatorService instance = null;
	public static CreatorService GetInstance
	{
		get
		{
			if (instance == null)
				instance = new CreatorService();
			return instance;
		}
	}
	
	private CreatorService()
	{
        this.GetSavedCards();
        this.getAllActions();

        this.activeCard = "BobsAction";
	}
    //****************************************************************************************

    public List<string> cards;
    public string activeCard;

    List<string> actionPaths;
    List<string> cardActions;

    public Action actionPreparing;

    public void GetSavedCards()
    {
        this.cards = new List<string>();  
        string root = @"Assets/Resources/Cards";
        // Get all subdirectories
        string[] subdirectoryEntries = Directory.GetDirectories(root);
        foreach (var dir in subdirectoryEntries)
        {
            this.cards.Add(dir.Split('\\')[1]);
        }
        
    }

     public void getAllActions()
     {
         string[] guids = AssetDatabase.FindAssets("t:"+ typeof(Action).Name);
         actionPaths = new List<string>();

         for(int i =0;i<guids.Length;i++)     
         {
             string path = AssetDatabase.GUIDToAssetPath(guids[i]);
            //  Action a = AssetDatabase.LoadAssetAtPath<Action>(path);
            actionPaths.Add(path);
         }
        if(actionPaths.Count()>0 && !String.IsNullOrEmpty(activeCard))
            this.getActionsForCard();
     }

     public void getActionsForCard(){

         cardActions = new List<string>();
         foreach (var path in actionPaths)
        {
            if(!String.IsNullOrEmpty(activeCard) && path.Contains(activeCard)) {
                string asset = path.Split('/').Last();
                this.cardActions.Add(asset.Split('.')[0]);
            }
        }
     }

    public void getActionsForCard(string cardName){
         cardActions = new List<string>();
         foreach (var path in actionPaths)
        {
            if(path.Contains(cardName)) {
                this.cardActions.Add(path.Split('\\').Last());
            }
        }
        // Debug.Log(String.Join("\n", this.cardActions));
     }

    public void addDropdownItems(GameObject dropdownObject, List<string> list) {
        try
        {
            TMP_Dropdown dropdown = dropdownObject.GetComponent<TMP_Dropdown>();
            foreach (var item in list)
            {
                dropdown.options.Add(new TMP_Dropdown.OptionData(){text = item});
            }
        }
        catch (System.Exception)
        {
            Debug.Log("Not A Dropdown");
        }
    }

    public void addDropdownItems(GameObject dropdownObject, string ddType) {
        this.addDropdownItems(dropdownObject, EnumValues(ddType));
    }

    public string getDropdownValue(GameObject dropdownObject, List<string> list){
        try
        {
            return list[dropdownObject.GetComponent<TMP_Dropdown>().value-1];

        }
        catch (System.Exception)
        {
            Debug.Log("Not a dropdown");
            return null;
        }
    }

    public void resetDropdownValue(GameObject dropdownObject){
        dropdownObject.GetComponent<TMP_Dropdown>().value = 0;
    }

    public string getDropdownValue(GameObject dropdownObject, string enumType){
        return getDropdownValue(dropdownObject, EnumValues(enumType));
    }

    public static List<string> EnumValues(string enumName) {
        Type EnumType = GetEnumType(enumName);
        string[] enumNames = Enum.GetNames(EnumType);

        return new List<string>(enumNames);
    }

    public static Type GetEnumType(string enumName)
    {
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            var type = assembly.GetType(enumName);
            if (type == null)
                continue;
            if (type.IsEnum)
                return type;
        }
        return null;
    }

    public void createAction(string actionName) {

        string path = "Assets/Resources/Cards/" + this.activeCard + "/Actions";
        System.IO.Directory.CreateDirectory(path);

        AssetDatabase.CreateAsset(actionPreparing, path + "/" + actionName + ".asset");
        AssetDatabase.SaveAssets();
    }

    public void setAction(){
        this.actionPreparing = ScriptableObject.CreateInstance<Action>() as Action;
    }

}
