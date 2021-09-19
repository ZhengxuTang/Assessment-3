using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanControl : MonoBehaviour
{
    public Animator animatorController;
    [SerializeField]
    public GameObject Pacman;
    private Tweener tweener;
    public AudioSource moveMusic;

    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();

        if (Pacman.transform.position != new Vector3 (-0.5f, 1.5f, 0.0f))
        {
            tweener.AddTween(Pacman.transform, Pacman.transform.position, new Vector3 (-0.5f, 1.5f, 0.0f), 0.0f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Pacman.transform.rotation = Quaternion.Euler(0, 0, 180);

        if (Pacman.transform.position == new Vector3 (-0.5f, 1.5f, 0.0f))
        {
            animatorController.SetTrigger("LeftParam");
            tweener.AddTween(Pacman.transform, new Vector3 (-0.5f, 1.5f, 0.0f), new Vector3 (-5.5f, 1.5f, 0.0f), 2.0f);
            moveMusic.Play();
        }

        if (Pacman.transform.position == new Vector3 (-5.5f, 1.5f, 0.0f))
        {
            animatorController.SetTrigger("UpParam");
            tweener.AddTween(Pacman.transform, Pacman.transform.position, new Vector3 (-5.5f, 5.5f, 0.0f), 2.0f);
            moveMusic.Play();
        }

        if (Pacman.transform.position == new Vector3 (-5.5f, 5.5f, 0.0f))
        {
            animatorController.SetTrigger("RightParam");
            tweener.AddTween(Pacman.transform, Pacman.transform.position, new Vector3 (-0.5f, 5.5f, 0.0f), 2.0f);
            moveMusic.Play();
        }

        if (Pacman.transform.position == new Vector3 (-0.5f, 5.5f, 0.0f))
        {
            animatorController.SetTrigger("DownParam");
            tweener.AddTween(Pacman.transform, Pacman.transform.position, new Vector3 (-0.5f, 1.5f, 0.0f), 2.0f);
            moveMusic.Play();
        }
    }
}
