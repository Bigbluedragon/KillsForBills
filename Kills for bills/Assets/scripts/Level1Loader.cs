using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Loader : MonoBehaviour
{
    public void changeScene()
    {
        SceneManager.LoadScene("Sample level");
    }
}
