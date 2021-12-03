<Query Kind="Program" />

void Main()
{
	string s = "abcacas"; //abcacasabcac as
	int n = 12;

	Console.WriteLine(FrequeencyOfRepetedCharachter(s, 'a', n));
}

public int FrequeencyOfRepetedCharachter(string s, char letter, int n)
{
	var charList = s.ToCharArray();
	var stringLength = charList.Length;
	var letterRepetition = charList.Count(l => l == letter);
	var modulus = n % stringLength;

	var numberOfLettersWithooutModulus = letterRepetition * (n / stringLength);

	var modulusArray = new char[modulus];
	Array.Copy(charList, modulusArray, modulus);

	var modulusCount = modulusArray.Count(l => l == letter);

	return numberOfLettersWithooutModulus + modulusCount;
}
// Define other methods and classes here
