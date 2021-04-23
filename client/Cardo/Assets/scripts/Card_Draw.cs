using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Card_Draw : MonoBehaviour
{
    public int card_num;
    private Card card;
    private bool card_assigned;
    Ray ray;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start(){ // START Open
        card = null;
        card_num = -1;
        Debug.Log("Started!");
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit))
        {
            if(Input.GetMouseButtonDown(0)){
                print(hit.collider.name);
                if(card != null && hit.collider.name == "Card_model"){
                    Debug.Log("OnMouseDown_Entered If statement");
                    card.triggerAbility();
                }
            }

        }
        if(card_num >= 0 && !card_assigned){ // If-1 OPEN
            assign_card();
        } // IF-1 CLOSE
        
    }
    
    
    void OnMouseDown(){
         Debug.Log("Inside OnMouseDown");
            if(card != null)
            {
                Debug.Log("OnMouseDown_Entered If statement");
                card.triggerAbility();
            }
        }
    private void assign_card()
        {
            Debug.Log("Entered assign_card");
            card = new Card(card_num);
            card_assigned = true;

        } 
}
