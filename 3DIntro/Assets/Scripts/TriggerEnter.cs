using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnter : MonoBehaviour
{
    public PlayAudioScript enterDoorMusic;
    public PlayAudioScript phoneRinging;
    public PhoneGoDark darkPhone;

    public bool nearThePhone;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Door"){
            Debug.Log ("I've entered the doorway");
            enterDoorMusic.PlayMyself();
        } else if (other.tag == "Phone"){
            Debug.Log ("This is the phone");
            nearThePhone = true;
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.tag == "Door"){
            Debug.Log ("I'm in the doorway");
        } else if (other.tag == "Phone"){
            if (Input.GetMouseButton(0)){

            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Door"){
            Debug.Log ("I've left the doorway");
        }else if (other.tag == "Phone"){
            nearThePhone = false;
        }
    }


    void Update(){
        if (nearThePhone && Input.GetKeyDown(KeyCode.E)){
            //If near the phone, and hit E, stop playing the phone sound
            phoneRinging.ShutMyselfUp();
            darkPhone.TurnOffPhoneScreen();
        }
    }
}
