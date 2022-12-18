using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamCoin : MonoBehaviour
{

    public int coins;
    public GameObject[] objectSpawn;
    public int objectCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ObjectDrop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator ObjectDrop(){
        while(objectCount < 10){

            int randomIndex = Random.Range(0, objectSpawn.Length);

            Vector3 randomSpawnPos = new Vector3(Random.Range(-10,11),1,Random.Range(-10,11));

            Instantiate(objectSpawn[randomIndex], randomSpawnPos, Quaternion.identity);

            yield return new WaitForSeconds(0.1f);

            objectCount+=1;
        }
    }

    public void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Cube" || col.gameObject.tag == "Sphere"  || col.gameObject.tag == "Capsule" ){
            //Debug.Log("OnTriggerEnter");
            coins = coins + 1;
            DisplayCoins.numberOfDisplayCoins = coins;
            col.gameObject.SetActive(false);
            // Destroy(col.gameObject);
        }
    }
}
