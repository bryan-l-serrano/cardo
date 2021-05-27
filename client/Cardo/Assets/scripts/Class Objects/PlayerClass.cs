using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass {

	// INSTANTIATES AS A SINGLETON
	private static PlayerClass instance = null;
	public static PlayerClass GetInstance
	{
		get
		{
			if (instance == null)
				instance = new PlayerClass();
			return instance;
		}
	}
	
	private PlayerClass()
	{
	}
    // ****************************************

	//TODO For now the player is set to player1 for testing but this will be set 
	public PlayerType playerType = PlayerType.PLAYER1;

}