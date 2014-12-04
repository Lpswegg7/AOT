using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class PPSerialization 
{
	public static BinaryFormatter binaryFormatter = new BinaryFormatter();

	public static void Save(string saveTag, object obj)
	{
				MemoryStream memoryStream = new MemoryStream ();
				binaryFormatter.Serialize (memoryStream, obj);
				string temp = System.Convert.ToBase64String (memoryStream.ToArray ());
				PlayerPrefs.SetString (saveTag, temp);
	}

	//Created a public variable, it returns and object, we will call it load. 
	//We're going to send it the tag that PlayerPrefs is going to point to, to get the value.
	public static object Load(string saveTag) 
	{
		string temp = PlayerPrefs.GetString (saveTag);
		if (temp == string.Empty) //going to check the value, if it's empty we're not going to return anything
		{
			return null;
		}
		//Set up a MemoryStream, which we manipulate with the binaryformatter to serialize our object
		//then we are going to return that object.
		MemoryStream memoryStream = new MemoryStream (System.Convert.FromBase64String (temp));
		return binaryFormatter.Deserialize (memoryStream);
	}


}
