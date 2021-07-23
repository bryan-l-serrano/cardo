using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AUX_Actions_Load : MonoBehaviour
{
    public MultiSelect blockCardToggle;
    CreatorService creatorService;
    // Start is called before the first frame update
    void Start()
    {
        creatorService = CreatorService.GetInstance;
        blockCardToggle.stringList = creatorService.cards;
        blockCardToggle.loadToggles();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
