using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalManager : MonoBehaviour
{
    public Text text;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        text.text = count.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cube") 
        {
            count++;
            text.text = count.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
