using System;
using NUnit.Framework;

public class Program
{
	public static void Main()
	{
		Assert.AreEqual(true, isValid("CABDDACCCA",3));			
		Assert.AreEqual(false, isValid("EABDACCAE",3));		
		Assert.AreEqual(true, isValid("CABDDDDACCCA",4));
		Assert.AreEqual(true, isValid("ABBDCA",2));		
		Assert.AreEqual(true, isValid("BAAABDBB",3));		
		Assert.AreEqual(false, isValid("BAABDB",3));
	}
	
	public static bool isValid(String chaine, int number){
		var temp = "";
		int cnt = 0;
		for(int i=0;i<chaine.Length;i++){
			if(temp.Length!=0 && temp[temp.Length-1]!=chaine[i]){
				temp=chaine[i].ToString();
				cnt=1;
			}
			else{
				temp=temp+chaine[i];
				cnt=cnt+1;
			}
			if(cnt==number){
				return true;
			}
			
		}
		return false;
	}
}