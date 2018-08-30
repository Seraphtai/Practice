using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour {
    public Sprite[] sprites;
    public int fps;

    private float t;
    private float time;
    private SpriteRenderer spriteRenderer;
    private int index;
    // Use this for initialization
    void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        t = 1.0f / fps;
    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time >= t)
        {
            time = 0;
            spriteRenderer.sprite = sprites[index];
            index++;
            if (index >= sprites.Length)
            {
                index = 0;
            }
        }
    }
}
