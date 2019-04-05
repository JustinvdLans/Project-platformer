using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
	public GameObject player; 
	public Player playerScript;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerScript = player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Funtion for a coin
    void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.CompareTag("Player"))
    	{
    		Debug.Log(playerScript.points);
    		playerScript.points++;
    		//Add 1 to points.
    		Destroy(gameObject); // this destroys things
    	
    	}
    }
}
