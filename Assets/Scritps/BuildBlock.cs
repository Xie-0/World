using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildBlock : MonoBehaviour
{
    public GameObject stone;
    public GameObject wood;
    public GameObject mud;
    public GameObject ironBlock;
    public GameObject diamondBlock;
    public GameObject commandBlock;
    public AudioClip audioClipStone;
    public AudioClip audioClipWood;
    public AudioClip audioClipMud;
    public AudioClip audioClipIronBlock;
    public AudioClip audioClipDiamondBlock;
    public AudioClip audioClipCommandBlock;
    string thing = "stone";
    public string commandBlock_input = "f";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if(thing == "stone")
                {
                    GameObject.Instantiate(stone, hit.point, transform.rotation);
                    AudioSource.PlayClipAtPoint(audioClipStone, transform.localPosition);
                }
                if (thing == "wood")
                {
                    GameObject.Instantiate(wood, hit.point, transform.rotation);
                    AudioSource.PlayClipAtPoint(audioClipWood, transform.localPosition);
                }
                if (thing == "mud")
                {
                    GameObject.Instantiate(mud, hit.point, transform.rotation);
                    AudioSource.PlayClipAtPoint(audioClipMud, transform.localPosition);
                }
                if (thing == "ironBlock")
                {
                    GameObject.Instantiate(ironBlock, hit.point, transform.rotation);
                    AudioSource.PlayClipAtPoint(audioClipIronBlock, transform.localPosition);
                }
                if (thing == "diamondBlock")
                {
                    GameObject.Instantiate(diamondBlock, hit.point, transform.rotation);
                    AudioSource.PlayClipAtPoint(audioClipDiamondBlock, transform.localPosition);
                }
                if (thing == "commandBlock")
                {
                    GameObject.Instantiate(commandBlock, hit.point, transform.rotation);
                    AudioSource.PlayClipAtPoint(audioClipCommandBlock, transform.localPosition);
                }
            }
        }
        if (Input.GetKeyDown("1"))
        {
            thing = "stone";
        }
        else if(Input.GetKeyDown("2"))
        {
            thing = "wood";
        }
        else if (Input.GetKeyDown("3"))
        {
            thing = "mud";
        }
        else if (Input.GetKeyDown("4"))
        {
            thing = "ironBlock";
        }
        else if (Input.GetKeyDown("5"))
        {
            thing = "diamondBlock";
        }
        else if (Input.GetKeyDown(commandBlock_input))
        {
            thing = "commandBlock";
        }
    }
    void OnGUI()
    {
        GUILayout.TextArea(thing);
    }
}
