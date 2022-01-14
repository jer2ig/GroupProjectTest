using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSet : MonoBehaviour
{
    // Start is called before the first frame update
    public Text txt;
    void Start () {
         txt = gameObject.GetComponent<Text>(); 
         txt.text="Mudimap v2";  
     }
     
     // Update is called once per frame
     void Update () {
     }
}
