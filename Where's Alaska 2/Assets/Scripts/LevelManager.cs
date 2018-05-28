using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    private int currentLevel;
    private float border = 0.2f;
    private List<GameObject> states;
    private TextureManager textureManager;
    public GameObject statePrefab;

	// Use this for initialization
	void Start () {
        textureManager = this.GetComponent<TextureManager>();
        for (int i = 0; i < 50; i++)
        {
            GameObject go = Instantiate(statePrefab, transform);
            SpriteRenderer spriteRenderer = go.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = textureManager.GetRandomNonAlaskaTexture();
            go.transform.position = GetRandomPosition();
        }
	}

    void StartNewLevel() {
        
    }

    private Vector2 GetRandomPosition() {
        Bounds cameraBounds = OrthographicBounds(Camera.main);
        float randomX = Random.Range(cameraBounds.min.x + border, cameraBounds.max.x - border);
        float randomY = Random.Range(cameraBounds.min.y + border, cameraBounds.max.y - border);
        return new Vector2(randomX, randomY);
    }

    private Bounds OrthographicBounds(Camera camera)
    {
        float screenAspect = (float)Screen.width / (float)Screen.height;
        float cameraHeight = camera.orthographicSize * 2;
        Bounds bounds = new Bounds(
            camera.transform.position,
            new Vector3(cameraHeight * screenAspect, cameraHeight, 0));
        return bounds;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
