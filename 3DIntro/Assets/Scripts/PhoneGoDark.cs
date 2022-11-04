using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneGoDark : MonoBehaviour
{
    public MeshRenderer myRenderer;
    public Material unlitScreenMaterial;

    public void TurnOffPhoneScreen(){
        myRenderer.material = new Material (
            unlitScreenMaterial
        );
    }
}
