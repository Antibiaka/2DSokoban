using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level 
{
    public List<List<Field>> levelLayout;
    public List<Vector2Int> targets; //targets fields
    public int width=10;
    public int height=10;
    public static string[] levelArray;

    public Level() {
        string demoLevel =
@"#########
#....._._.#
#..$.$..$.#
#....@.._.#
###########";
        CreateFromString(demoLevel);
    }
    Level(string s) {
        CreateFromString(s);
    }
    private void CreateFromString(string a) {
        //char[] charArr;
        //#-wall , . - ground , _-target field , $-box , @-palyer
         levelArray = a.Split('\n'); //layers
        for (int i = 0; i < levelArray.Length; i++) {
            //charArr = levelArray[i].ToCharArray(); 
            for (int j = 0; j < levelArray[j].Length; j++) {

            }
            Debug.Log(levelArray[i]);
        }


       // Debug.Log();
        

    }
}
