using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Inv_Pers : MonoBehaviour
{
    public Inventared inv_Icon;
    public List<int> index;
    public Image[] image;
    public GameObject fon;
    public UnityEvent<bool> clic;
    public static Inv_Pers rid { get; set; }
    void Awake()
    {
        InvOff();
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    public void InvOn() 
    {
        clic.Invoke(true);
        fon.SetActive(true);
    }
    public void InvOff() 
    {
        index.Clear();
        clic.Invoke(false);
        fon.SetActive(false);

    }

    private void FixedUpdate()
    {

        if (index.Count > 0)
        {
            for (int i = 0; i < index.Count; i++)
            {
                image[i].sprite = inv_Icon.icon[index[i]];
            }
        }
        
        else
        {
            for (int i = 0; i < image.Length; i++)
            {
                image[i].sprite = inv_Icon.icon[0];
            }
            
        }
    }
}
