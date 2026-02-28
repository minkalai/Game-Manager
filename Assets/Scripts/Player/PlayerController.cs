using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI coins;

    public int coinCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinCount = 0;
        coins.text = coinCount.ToString();

	}

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
		//GameObject triggerObject = other.gameObject;
        //Tilemap object = other.GetComponent<Tilemap>();

		if (other.tag == "Treasure")//triggerObject.tag == "Treasure")
        {
            coinCount++;
            //triggerObject.gameObject.SetActive(false);
            other.gameObject.SetActive(false); 
		}
	}
}
