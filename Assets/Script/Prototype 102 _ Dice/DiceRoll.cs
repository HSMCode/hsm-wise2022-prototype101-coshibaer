using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    public int diceNumber;
    public int luckyOne = 5;
    public int luckyTwo = 42;
    public int luckyThree = 13;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            diceNumber = Random.Range(1, 50);
            Debug.Log("Dice Number: " + diceNumber);
        
        if (diceNumber == luckyOne) {
                Debug.Log ( "Du hast gewonnen mit der Nummer:  "  + luckyOne);
            }

        if (diceNumber == luckyTwo)
            {
                Debug.Log("Du hast gewonnen mit der Nummer:  " + luckyTwo);
            }
         if (diceNumber == luckyThree)
            {
                Debug.Log("Du hast gewonnen mit der Nummer:  " + luckyThree);
            }

        }

    }
}