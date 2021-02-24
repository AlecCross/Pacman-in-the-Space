using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneHealer : MonoBehaviour
{
    private HealthStat healthStat;
    private double hp;
    private bool isRegeneration;
    public Text _endGame; 
    
    void Start(){
        healthStat = gameObject.GetComponent<HealthStat>();
        print(gameObject.name+" Старт Здоровье "+hp);
        hp = healthStat.hp;
        isRegeneration = healthStat.regeneration;
        print(gameObject.name+" Присвоили Здоровье "+hp);
    }

    void OnTriggerStay(Collider other){
        if(other.tag=="Healing" && gameObject.name == "Player"){
            if(hp<99){
                hp+= Time.deltaTime * 5;
                print(gameObject.name+" Увеличение Здоровья "+hp);
            }
            else if(hp>=99&&hp<100)
            {   hp = 100;
                print(gameObject.name+" Здоров "+hp);
            }
        }
        if(other.tag=="Damager"){
            hp-= Time.deltaTime * 15;
            print(gameObject.name+" Здоровье "+hp);
            isRegeneration = false;
            healthStat.regeneration = isRegeneration;
            healthStat.hp = hp;
        }
        if(other.tag=="Trap" && gameObject.name != "Player"){
            hp-= Time.deltaTime * 15;
            print(gameObject.name+" Здоровье "+hp);
            isRegeneration = false;
            healthStat.regeneration = isRegeneration;
            healthStat.hp = hp;
        }
    }
    void OnTriggerExit(Collider other){
        if(other.tag=="Damager" && gameObject.name != "Player"){
            isRegeneration = true;
            healthStat.regeneration = isRegeneration;
        }
    }

    void Update(){
        if(hp<1){
            gameObject.SetActive(false);
            print(gameObject.name+" Убит");
            if(gameObject.name=="Player"){
                _endGame.text = "Game Over";
            }
        }
    }
    
}
