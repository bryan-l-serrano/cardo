using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Concurrent;

public class CounterAction
{
    //SINGLETON *****************************
	private static CounterAction instance = null;
	public static CounterAction GetInstance
	{
		get
		{
			if (instance == null)
				instance = new CounterAction();
			return instance;
		}
	}
	
	private CounterAction()
	{
        counterMap = new ConcurrentDictionary<string, int>();

	}
    // ****************************************

    public ConcurrentDictionary<string, int> counterMap;

    public void updatedCounter(string key, int updateValue) {
        counterMap.AddOrUpdate(key, updateValue, (key,value) => value + updateValue);
    }
}