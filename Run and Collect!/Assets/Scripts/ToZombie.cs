using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToZombie : MonoBehaviour
{
    public void toZombie()
    {
        SceneManager.LoadScene("Zombie");
    }
}
