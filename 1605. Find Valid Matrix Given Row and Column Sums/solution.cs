using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum) {
        foreach(var rowItem in rowSum){
            posibilties2D(rowItem);
            Console.WriteLine("_____");
        }
        // loop on each list if [0] + [0] from every one [0] in col go next
        // in the end just return the result
        return null;
    }

    public int[][] posibilties2D(int number) {
        List<int> temp = new List<int>();
        // revrese starter , ender to take all possiblites
        int startindex = 0;
        int endindex = number;
        for(int i = 0 ; i < number ; i++){
            temp.Add(startindex + i);
            temp.Add(endindex - i);   
        }

        foreach (int element in temp) {
            Console.WriteLine(element);
        }

        return null;
    }
    public void posobilies3D(int number){
        // take all posibilites like 3d
    }
    // make one function of possilbity take numLoop and creat list with it all items is zero instead the last item
    // make it equal the number 
    // and start looping by make the last index is contstant key loop wil be count - 1 
    // and change the the index to get all the posibilites of trying 
}
