using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScreenManager : MonoBehaviour
{
    public void SwitchScreen(int index)
    {
        SceneManager.LoadScene(index);
    }
}
