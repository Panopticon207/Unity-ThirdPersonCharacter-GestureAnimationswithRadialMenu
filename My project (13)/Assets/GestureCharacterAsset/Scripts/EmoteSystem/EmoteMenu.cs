using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmoteMenu : MonoBehaviour
{
    public GameObject emotetMenuCircle;
    public GameObject selectionPoint;

    public GameObject slotInfoSprite;
    public Text titleText;
    public Text descriptionText;
    public Animator playerAnim;
    string animBehaviour;
    public GameObject player;
    public List<string> animList;

    private void Update()
    {

        selectionPoint.transform.LookAt(Input.mousePosition);

        RaycastHit2D hit = Physics2D.Raycast(selectionPoint.transform.position, selectionPoint.transform.forward,1000000f);
        if (hit)
        {
            //Debug.Log("Hit" + hit.collider.name);
            //hit.transform.GetComponent<Image>().color = Color.red;
            var rotationZ = hit.transform.GetComponent<EmoteMenuSlot>().rotationValue;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotationZ));
            slotInfoSprite.gameObject.SetActive(true);
            slotInfoSprite.GetComponent<Image>().sprite = hit.transform.GetComponent<EmoteMenuSlot>().slotImage;
            titleText.text = hit.transform.GetComponent<EmoteMenuSlot>().titleText;
            descriptionText.text = hit.transform.GetComponent<EmoteMenuSlot>().descriptionText;


            if (Input.GetMouseButtonDown(0))
            {
                animBehaviour = hit.transform.GetComponent<EmoteMenuSlot>().animBehaviour;
                foreach (var anim in animList) // To cancel other animations 
                {
                    if (animBehaviour == anim) 
                    {
                        playerAnim.SetBool(animBehaviour, true);
                    }
                    else
                    {
                        playerAnim.SetBool(anim, false);
                    }
                }


                animBehaviour = hit.transform.GetComponent<EmoteMenuSlot>().animBehaviour;
                //playerAnim.SetBool(animBehaviour,true);
            }
        }
        else // empty slot
        {

        }


    }


}
