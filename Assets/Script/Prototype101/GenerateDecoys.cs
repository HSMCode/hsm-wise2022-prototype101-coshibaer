using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateDecoys : MonoBehaviour
{
    public GameObject Goal;

    public int spawnAmount = 5;
    public float spawnPositionX = Mathf.Floor(15f);
    public float spawnPostitonZ = Mathf.Floor(15f);

    public float startDelay = 2f;
    public float startInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        //SpawningDecoy();

        //InvokeRepeating("SpawningDecoy", startDelay, startInterval);
        // InvokeRepeating("SpawningDecoy", time, repeatRate)
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("p"))
        {

            // Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0,Random.Range(-spawnPostitonZ,spawnPostitonZ));
            //Debug.Log(spawnPosition);

                //instanitate decoy
                //Instantiate(Goal, spawnPosition, transform.rotation);

                // for (int i = 0; i < spawnAmount; i++)
                // {
                    // generate random spawn position between the defined values
                //    Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0,Random.Range(-spawnPostitonZ,spawnPostitonZ));
                    
                //    // instantiate decoy
                //    Instantiate(Goal, spawnPosition, transform.rotation);
                // }

        // SpawningDecoy();

            SpawningDecoyParam(spawnAmount);

        }

    }

    void SpawningDecoy()
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            // generate random spawn position between the defined values
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0,Random.Range(-spawnPostitonZ,spawnPostitonZ));
            
            // instantiate decoy
            Instantiate(Goal, spawnPosition, transform.rotation);
        }
    }

        void SpawningDecoyParam(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            // generate random spawn position between the defined values
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0,Random.Range(-spawnPostitonZ,spawnPostitonZ));
            
            // instantiate decoy
            Instantiate(Goal, spawnPosition, transform.rotation);
        }
    }
}
