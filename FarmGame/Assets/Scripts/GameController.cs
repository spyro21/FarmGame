using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject playerObject;
    public GameObject farmObject;

    // Start is called before the first frame update
    void Start()
    {
        farmObject = Instantiate(farmObject, new Vector3(2,0,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
