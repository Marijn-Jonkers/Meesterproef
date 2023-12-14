using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeSpherePyramid : MonoBehaviour
{
    public GameObject cube;
    public string cubeName;
    public GameObject sphere;
    public string sphereName;
    public GameObject pyramid;
    public string pyramidName;




    // Start is called before the first frame update
    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();

        dropdown.options.Clear();

        List<string> items= new List<string>();
        items.Add(cubeName); 
        items.Add(sphereName);
        items.Add(pyramidName);

        foreach(var item in items)
        {
            dropdown.options.Add(new Dropdown().OptionData() { text = item});
        }

        dropdown.onValueChanged.AddListener(delegate { DropdownItemsSelected(dropdown); });

    }
    void DropdownItemsSelected(Dropdown dropdown)
    {
        if text
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
