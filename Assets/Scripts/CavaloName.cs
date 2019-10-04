using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CavaloName : MonoBehaviour
{
    public Text dialogBox;
    public GameObject caixa;
    private Vector3 GetVector3;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        GetVector3 = new Vector3((caixa.transform.position.x + 1f), caixa.transform.position.y, 25f);
        if (transform.position != GetVector3)
            transform.position = Vector3.Lerp(transform.position, GetVector3, 1);
        dialogBox.text = caixa.name;
    }
}
