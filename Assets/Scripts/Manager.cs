using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int choose;

    private static Manager buat;
	public static Manager Buat{
		get 
		{ 
			if (buat == null) buat = GameObject.FindObjectOfType<Manager>(); 
			return buat;
		}
	}
}
