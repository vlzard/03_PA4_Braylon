using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoCubeScene : MonoBehaviour
{

    private float Timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += 1 * Time.deltaTime;
        
        if(Timer > 1)
        {
            SceneManager.LoadScene("CubeScene");
        }
    }
}
