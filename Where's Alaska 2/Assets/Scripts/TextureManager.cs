using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureManager : MonoBehaviour {

    private List<Sprite> textures;
    private Sprite alaskaTexture;

	// Use this for initialization
	void Start () {
        Sprite[] tempSprites = Resources.LoadAll<Sprite>("states_spritesheet");
        Debug.Log(tempSprites.Length);
        textures = new List<Sprite>(tempSprites);
        alaskaTexture = textures[1];
        textures.RemoveAt(1);
	}
	
    public Sprite GetRandomNonAlaskaTexture() {
        return textures[Random.Range(0, textures.Count - 1)];
    }

    public Sprite GetAlaskaTexture() {
        return alaskaTexture;
    }
}
