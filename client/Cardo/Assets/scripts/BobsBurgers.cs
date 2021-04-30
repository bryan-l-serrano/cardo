using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BobsBurgers : MonoBehaviour
{
    private GameState gameState;
    Ray ray;
    RaycastHit hit;
    public GameObject card;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        onClickFunctions();
    }


    public void onClickFunctions(){
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit))
        {
            if(Input.GetMouseButtonDown(0)){
                print(hit.collider.name);
                if(card != null && hit.collider.name == "Card_model"){
                    Debug.Log("OnMouseDown_Entered If statement");
                    //card.triggerAbility();
                }
                if(hit.collider.name == "Deck"){
                    gameState.drawCard(PlayerType.PLAYER);
                    placeCard();
                    // string printString = "";
                    // foreach (Card card in gameState.playerHand.getDeck())
                    // {
                    //     printString += card.ToString() + ", ";
                    // }
                    // Debug.Log(printString);
                }
            }

        }
        // if(card_num >= 0 && !card_assigned){ // If-1 OPEN
        //     assign_card();
        // } 
    }

    public void placeCard() {
        
    }
}
