using UnityEngine;

public class Door : MonoBehaviour
{
    public BoxCollider2D door;
    public Rock1 Rune1;
    public Rock1 Rune2;
    public Rock1 Rune3;

    public Sprite[] doorGlyph;
    public Sprite[] doorGlyphLit;

    public SpriteRenderer sp;
    public Sprite doorOpen;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Update()
    {
        if (Rune1.activatedRune1)
        {
            Debug.Log("rune 1 correct");
        }
        else if (Rune2.activatedRune2)
        {
            Debug.Log("rune 2 correct");
        }
        else if (Rune3.activatedRune3)
        {
            Debug.Log("rune 3 correct");
        }

        if (Rune1.activatedRune1 && Rune2.activatedRune2 && Rune3.activatedRune3)
        {
            sp.sprite = doorOpen;
            door.enabled = false;
            //audioManager.PlaySFX(audioManager.sfx[8]);
        }
    }
}
