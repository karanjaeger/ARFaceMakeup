using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeUpChanger : MonoBehaviour
{
    [SerializeField] private Material makeUpMat;
    [SerializeField] private Texture2D[] textures;
    
    void Start()
    {        
        makeUpMat.SetTexture("_Main_Tex", textures[0]);
    }
    public void ChangeMakeUp(int textureIndex)
    {
        makeUpMat.mainTexture = textures[textureIndex];
    }

}
