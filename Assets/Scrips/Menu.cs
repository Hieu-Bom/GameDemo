using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void play()
    {
        Application.LoadLevel("GameM1");
    }
    public void help()
    {
        Application.LoadLevel("Help");
    }
    public void Exit()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
