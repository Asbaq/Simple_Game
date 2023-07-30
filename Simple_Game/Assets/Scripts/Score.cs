using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int points = 0;
    [SerializeField] private Text PointText;
    [SerializeField] private AudioSource SoundEffect;

    void OnCollisionEnter(Collision collision)
    {     
            if(collision.gameObject.tag == "Sphere")
            {   
                Destroy(collision.gameObject);
                SoundEffect.Play();
                points+=10;
                PointText.text = "Points: " + points;
            }
            else if(collision.gameObject.tag == "Cylinder")
            {
                Destroy(collision.gameObject);
                SoundEffect.Play();
                points+=20;
                PointText.text = "Points: " + points;
            }
            else if(collision.gameObject.tag == "Cube")
            {
                Destroy(collision.gameObject);
                SoundEffect.Play();
                points+=30;
                PointText.text = "Points: " + points;
            }
            else if(collision.gameObject.tag == "Prism")
            {
                Destroy(collision.gameObject);
                SoundEffect.Play();
                points+=40;
                PointText.text = "Points: " + points;
            }
    }
}

