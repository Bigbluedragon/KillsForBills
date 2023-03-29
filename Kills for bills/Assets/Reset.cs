using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //proof it reset
        print("scene loaed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetScene()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }
}
