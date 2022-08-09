using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SafeZone : MonoBehaviour
{
    public ScoreManager score;
    public Life life;


    private void Update()
    {
        InputPlayer();

    }
    void InputPlayer()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D click = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (click.collider != null)
            {
                if (click.collider.tag == "Zombie")
                {
                    click.collider.GetComponent<Object>().SelfDestruct();
                    score.ScoreIncrement();
                }
                if (click.collider.tag == "Human")
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            life.GotDamage();
            
        }
        if (collision.gameObject.CompareTag("Human"))
        {
            
        }
    }
}
