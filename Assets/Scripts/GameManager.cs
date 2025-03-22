using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button SpawnMelee;

    void Start(){

    } 
    void Update(){

    }
    public void spawnMelee(){
        SpawnMelee.interactable=false;
        Debug.Log("Goat kondom");
    }


}
