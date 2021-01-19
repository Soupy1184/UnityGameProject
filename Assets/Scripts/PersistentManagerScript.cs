using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentManagerScript : MonoBehaviour
{
	public static PersistentManagerScript Instance {get; private set;}

	public int Value;
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance == null){
        	Instance = this;
        	DontDestroyOnLoad(gameObject);
        }
        else{
        	Destroy(gameObject);
        }
    }
}
