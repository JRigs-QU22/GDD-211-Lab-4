using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public RaycastHit2D hit;
    public Text Score;
    public AudioSource Blast;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Points", 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles += new Vector3(0f, 0f, Time.deltaTime * 100f);
            //Debug.Log("GO LEFT");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles += new Vector3(0f, 0f, Time.deltaTime * -100f);
            //Debug.Log("GO RIGHT");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Blast.Play();
            hit = Physics2D.Raycast(transform.position, transform.up);
            Debug.DrawRay(transform.position, transform.up * 100f, Color.green);
        }
        else
        {
            hit = Physics2D.Raycast(transform.up, transform.position);

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");

        }


        if (hit)
        {
            Debug.Log("hit");
            Debug.DrawRay(transform.position, transform.up * 100f, Color.red);
            Enemy hitEnemy = hit.collider.GetComponent<Enemy>();
            if (hitEnemy)
            {
                hitEnemy.TakeDamage(10f);
            }
        }

        Score.text = "Score:" + PlayerPrefs.GetInt("Points");

    }
}
