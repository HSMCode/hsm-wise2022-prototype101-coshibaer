using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{

    AudioSource winSound;
    public int diceNumber;
    //public int luckyOne = 5;
    //public int luckyTwo = 42;
    //public int luckyThree = 13;

    ParticleSystem Particles; // Particles

    public int[] luckyNumbers = { 5, 9, 10, 11, 29, 32, 45, 46 };

    // Start is called before the first frame update
    void Start()
    {
        winSound = GetComponent<AudioSource>();
        Particles = GetComponent<ParticleSystem>(); // Particles ziehen
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            diceNumber = Random.Range(1, 51);
            Debug.Log("Dice Number: " + diceNumber);

            for (int i = 0; i < luckyNumbers.Length; i++)
            {

                if (diceNumber == luckyNumbers[i])
                {
                    Debug.Log("Du hast gewonnen mit der Nummer: " + diceNumber + ", wuhuuu!");
                    winSound.Play(); //Win Sound spielt
                    Particles.Play(); //Particles spielen
                }
            else if (i == (luckyNumbers.Length - 1))
                {
                    Debug.Log("Damn, kein Glück, vielleicht nächstes mal.");
                }
            }

        }

    }
}