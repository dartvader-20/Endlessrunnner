using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameFlow : MonoBehaviour
{
    public Transform titleObj;
    private Vector3 nextGroundSpawn;
    public Transform treeObj;
    private Vector3 nextTreeSpawn;
    private int randX;
    public Transform boxObj;
    private Vector3 nextBoxSpawn;
    // Start is called before the first frame update
    void Start()
    {
        nextGroundSpawn.z = 49;
        StartCoroutine(spawnGround());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator spawnGround()
    { 
        yield return new WaitForSeconds(1);
        randX = Random.Range(-1, 2);
        nextTreeSpawn = nextGroundSpawn;
        nextTreeSpawn.y = .16f;
        nextTreeSpawn.x = randX;
        Instantiate(titleObj, nextGroundSpawn, titleObj.rotation);
        Instantiate(treeObj, nextTreeSpawn, treeObj.rotation);

        nextGroundSpawn.z += 7;
        randX = Random.Range(-1, 2);
        nextBoxSpawn = nextGroundSpawn;
        nextBoxSpawn.y = .176f;
        nextBoxSpawn.x = randX;
        Instantiate(titleObj, nextGroundSpawn, titleObj.rotation);
        Instantiate(boxObj, nextBoxSpawn, boxObj.rotation);
        nextGroundSpawn.z += 7;
        StartCoroutine(spawnGround());
    }
}
