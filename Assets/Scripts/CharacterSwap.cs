using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CharacterSwap : MonoBehaviour
{
    public Transform character;
    public List<Transform> possibleCharacters;
    public int whichCharacter;
    int wc;
    public CinemachineFreeLook cam;

    // Start is called before the first frame update
    void Start()
    {
        if(character == null && possibleCharacters.Count >= 1)
        {
            character = possibleCharacters[0];
        }
        Swap();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(whichCharacter == 0)
            {
                whichCharacter = possibleCharacters.Count - 1;
            }
            else
            {
                whichCharacter -= 1;
            }
            Swap();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(whichCharacter == possibleCharacters.Count - 1)
            {
                whichCharacter = 0;
            }
            else
            {
                whichCharacter += 1;
            }
            if(Vector3.Distance(possibleCharacters[whichCharacter].position, character.position) > 5)
            Swap();
        }
    }

    public void Swap()
    {
        character = possibleCharacters[whichCharacter];
        character.GetComponent<ThirdPersonMovement1>().enabled = true;
        for (int i = 0; i < possibleCharacters.Count; i++)
        {
            if(possibleCharacters[i] != character)
            {
                possibleCharacters[i].GetComponent<ThirdPersonMovement1>().enabled = false;
            }
        }
        cam.LookAt = character;
        cam.Follow = character;
    }
    
}
