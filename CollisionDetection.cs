using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject GOBLIN;
    public GameObject Troll;
    public GameObject Dragon;
    public GameObject Monster;
    public GameObject Treasure;
    public GameObject Treasure1;
    public GameObject Coins;
    public GameObject TurquoiseCrystal;
    public GameObject YellowCrystal;
    public GameObject RedCrystal;
    public GameObject GreenCrystal;
    public AnimationState state;

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "GOBLIN")
        {
            Debug.Log("collision detected!");
            var anim = GetComponent<Animator>();
            anim.SetTrigger("wave");
            var objAnim = col.GetComponent<Animation>();
            objAnim.Play("death");
            TurquoiseCrystal.SetActive(true);
        }
        if (col.name == "TurquoiseCrystal")
        {
            Debug.Log("collision detected");
            var anim = GetComponent<Animator>();
            anim.SetTrigger("pickup");
            Troll.SetActive(true);
            TurquoiseCrystal.SetActive(false);
        }
        if (col.name == "troll")
        {
            Debug.Log("collision detected");
            var anim = GetComponent<Animator>();
            anim.SetTrigger("wave");
            var objAnim = col.GetComponent<Animator>();
            objAnim.SetTrigger("death");
            YellowCrystal.SetActive(true);

        }
        if (col.name == "YellowCrystal")
        {
            Debug.Log("collision detected");
            var anim = GetComponent<Animator>();
            anim.SetTrigger("pickup");

            Dragon.SetActive(true);
            YellowCrystal.SetActive(false);
        }
        if (col.name == "DragonTerrorBringerMesh")
        {
            Debug.Log("collision detected");
            var anim = GetComponent<Animator>();
            anim.SetTrigger("wave");
            var objAnim = col.GetComponent<Animator>();
            objAnim.SetTrigger("die");
            RedCrystal.SetActive(true);

        }
        if (col.name == "Gem3Target")
        {
            Debug.Log("collision detected");
            var anim = GetComponent<Animator>();
            anim.SetTrigger("pickup");

            Monster.SetActive(true);
            RedCrystal.SetActive(false);
        }
        if (col.name == "Demon Blade Lord")
        {
            Debug.Log("collision detected");
            var anim = GetComponent<Animator>();
            anim.SetTrigger("wave");
            var objAnim = col.GetComponent<Animator>();
            objAnim.SetTrigger("die");
            GreenCrystal.SetActive(true);
            

        }
        if (col.name == "Gem4Target")
        {
            Debug.Log("collision detected");
            var anim = GetComponent<Animator>();
            anim.SetTrigger("pickup");

            Treasure.SetActive(true);
            GreenCrystal.SetActive(false);
        }
        if (col.name == "TreasureTarget")
        {
            Debug.Log("collision detected");
            var anim = GetComponent<Animator>();
            anim.SetTrigger("pickup");
            Treasure.SetActive(false);
            Treasure1.SetActive(true);
            Coins.SetActive(true);
        }
    }
}

