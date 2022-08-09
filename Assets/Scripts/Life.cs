using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    [SerializeField] GameObject[] life;

    [SerializeField] int lifes;
    int index;


    private void Update()
    {
        if (lifes == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void GotDamage()
    {
        lifes -= 1;
        life[index].SetActive(false);
        index++;
    }
}
