using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public string name;

    private void Start() {
        name = gameObject.name;
    }

    private void Update() {
        Vector3 movement = Vector3.zero;
        
        if(name == "BottomPaddle"){
            movement = MoveBottomPaddle();
        }
        else if(name == "TopPaddle"){
            movement = MoveTopPaddle();
        }
        else if(name == "RightPaddle"){
            movement = MoveRightPaddle();
        }
        else if(name == "LeftPaddle"){
            movement = MoveLeftPaddle();
        }

        transform.Translate(movement * Time.deltaTime);
    }

    private Vector3 MoveBottomPaddle(){
        if(Input.GetKey(KeyCode.RightArrow)){
            return Vector3.right *speed;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            return Vector3.left *speed;
        }
        else return Vector3.zero;
    }

    private Vector3 MoveTopPaddle(){
        if(Input.GetKey(KeyCode.D)){
            return Vector3.right *speed;
        }
        if(Input.GetKey(KeyCode.A)){
            return Vector3.left *speed;
        }
        else return Vector3.zero;
    }

    private Vector3 MoveRightPaddle(){
        if(Input.GetKey(KeyCode.UpArrow)){
            return Vector3.right *speed;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            return Vector3.left *speed;
        }
        else return Vector3.zero;
    }

    private Vector3 MoveLeftPaddle(){
        if(Input.GetKey(KeyCode.W)){
            return Vector3.right *speed;
        }
        if(Input.GetKey(KeyCode.S)){
            return Vector3.left *speed;
        }
        else return Vector3.zero;
    }
}
