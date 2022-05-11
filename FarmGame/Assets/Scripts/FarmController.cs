using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void plantCrop() {
        this.GetComponent<SpriteRenderer>().color = new Color(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
