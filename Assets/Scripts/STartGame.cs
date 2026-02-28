using UnityEngine;
using UnityEngine.UI;

public class STartGame : MonoBehaviour
{
	[SerializeField] Button Start, ResumeFromSave;
	[SerializeField] GameObject STartPanel;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void ResumeGameFromMenu()
	{
		if (JSonSaving.Instance.SaveFileExists())
		{
			JSonSaving.Instance.LoadData();
		}
	}
}
