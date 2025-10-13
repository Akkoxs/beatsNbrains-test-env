using UnityEngine;
using System;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    //Misc
    private Transform trans;
    private Coroutine corotContainer = null;

    [Header("Player Inputs")]
    [SerializeField] private string UpKey;
    [SerializeField] private string DownKey;
    [SerializeField] private string HitKey;
    private KeyCode keyCodeUp;
    private KeyCode keyCodeDown;
    private KeyCode keyCodeHit;

    [Header("Movement Params")]
    [SerializeField] private LaneReferences lanerefs;
    [SerializeField] private float moveSpeedY;
    [SerializeField] private float moveSpeedX;
    [SerializeField] private int startLane;


    void Start()
    {
        //components 
        trans = GetComponent<Transform>();

        int currLane = startLane;


        //KeyCode defs & converts string into enum for KeyCode use 
        // TryParse(string, ignoreCaseSensitivity, successful output memory location)
        if (Enum.TryParse(UpKey, true, out KeyCode keyCodeUp)) ;
        if (Enum.TryParse(DownKey, true, out KeyCode keyCodeDown)) ;
        if (Enum.TryParse(HitKey, true, out KeyCode keyCodeHit)) ;

    }

    // void Update()
    // {

    //     //vertical movement
    //     if (Input.GetKeyDown(keyCodeUp) && corotContainer == null){
    //         corotContainer = StartCoroutine(ChangeLane("Up"), 1f);

    //     }

    //     else if (Input.GetKeyDown(keyCodeDown) && corotContainer == null){
    //          corotContainer = StartCoroutine(ChangeLane("Down", 1f));

    //     }

    // }

    // IEnumerator ChangeLane(string direc, float duration)
    // {

    //     switch (direc){
    //         case "Up":
    //             //sp = currLane;
    //             break;
    //         case "Down":
    //             break;
    //     }
        
    //     float elapsed = 0f; 
    //     while (elapsed < duration){
            
    //     }

    //     corotContainer = null;
    //     yield return null;
    // }

}
    
