using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneHealer : MonoBehaviour
{
    private HealthStat healthStat;
    public double hp;
    public Text _endGame; 
    
    void Start(){
        healthStat = gameObject.GetComponent<HealthStat>();
        print(gameObject.name+" Старт Здоровье "+hp);
        hp = healthStat.hp;
        print(gameObject.name+" Присвоили Здоровье "+hp);
    }

    void OnTriggerStay(Collider other){
        if(other.tag=="Healing"){
            if(hp<99){
                hp+= Time.deltaTime * 5;
                print(gameObject.name+" Увеличение Здоровья "+hp);
            }
            else if(hp>=99)
            {   hp = 100;
                print(gameObject.name+" Здоров "+hp);
            }
        }
        if(other.tag=="Damager"){
            hp-= Time.deltaTime * 5;
            print(gameObject.name+" Здоровье "+hp);
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
