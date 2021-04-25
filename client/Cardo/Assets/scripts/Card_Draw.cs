using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Card_Draw : MonoBehaviour
{
    public int card_num;
    private Card card;
    private bool card_assigned;
    public string cardText;
    private GameState gameState;
    Ray ray;
    RaycastHit hit;
    CardService cardService;
    // Start is called before the first frame update
    void Start(){ // START Open
        card = null;
        card_num = -1;
        gameState = new GameState();
        cardService = CardService.GetInstance;
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
                if(hit.collider.name == "Deck"){
                    gameState.drawCard(true);
                    string printString = "";
                    foreach (Card card in gameState.playerHand.getDeck())
                    {
                        printString += card.ToString() + ", ";
                    }
                    Debug.Log(printString);
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
            setCardText();
            card_assigned = true;

        } 

    private void setCardText() {
        cardText = cardService.getCardText(card_num);

        Transform transform = gameObject.transform;
        Transform textTransform = gameObject.transform.Find("Card Text");
        TextMesh textMesh = textTransform.gameObject.GetComponent(typeof(TextMesh)) as TextMesh;
        textMesh.text = cardText;

    }
}
