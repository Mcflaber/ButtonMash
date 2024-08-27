using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<GameObject> ImageList;
    public GameObject CurrentImage;
    public int ImageIndex;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            NextImage();
        }
    }
    public void NextImage()
    {


        ImageIndex++;



        CurrentImage.SetActive(false);

        if (ImageIndex >= ImageList.Count)
        {
            ImageIndex = 0;
        }

        CurrentImage = ImageList[ImageIndex];



        CurrentImage.SetActive(true);


    }
}
