using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineScript : MonoBehaviour
{

    public CinemachineVirtualCamera[] virtualCameras;
    public int previousIndex = 0;
    public int nextIndex = 1;
    public bool firstRound = true;

    // Start is called before the first frame update
    void Start()
    {
        virtualCameras[0].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            virtualCameras[previousIndex].gameObject.SetActive(false);
            virtualCameras[nextIndex].gameObject.SetActive(true);

            if(previousIndex == 9){
                previousIndex = -1;
                nextIndex = 0;
            }

            previousIndex++;
            nextIndex++;

            if(previousIndex == 9){     
                virtualCameras[previousIndex].gameObject.SetActive(true);
                nextIndex = 0;
            }
        }
    }
}
