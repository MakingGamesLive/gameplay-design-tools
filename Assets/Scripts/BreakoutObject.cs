using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakoutObject : MonoBehaviour
{
    public float xPosition;
    public float yPosition;
    public float speed;
    public float xDirection;
    public float yDirection;
    public float acceleration;
    public ObjectSprite objectSprite;

    public Dictionary<string, string> PropertiesList()
    {
        Dictionary<string, string> d = new Dictionary<string, string>();

        d.Add("xPosition", "float");
        d.Add("yPosition","float");
        d.Add("speed", "float");
        d.Add("xDirection","float");
        d.Add("yDirection","float");
        d.Add("acceleration","float");
        d.Add("objectSprite","ObjectSprite");
        d.Add("objectSprite.image","string");
        d.Add("objectSprite.xScale","float");
        d.Add("objectSprite.yScale","float");
        d.Add("objectSprite.rotation","float");
        d.Add("objectSprite.alpha","float");
        d.Add("objectSprite.collisionToggle","bool");

        return d;
    }
}

public class ObjectSprite : MonoBehaviour
{
    public string image;
    public float xScale;
    public float yScale;
    public float rotation;
    public float alpha;
    public bool collisionToggle;
}