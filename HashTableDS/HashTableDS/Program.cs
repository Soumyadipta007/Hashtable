using System;

namespace HashTableDS
{
    class Program
    {
        static void Main(string[] args)
        {
			MyMapNode<String, int> myHashMap = new MyMapNode<String, int>(5);
			String sentence = "to be or not to be";
			String[] words = sentence.ToLower().Split(" ");
			foreach (String word in words)
			{
				Console.WriteLine(word);
				int value = myHashMap.Get(word);
				if (value == 0)
					value = 1;
				else
					value = value + 1;
				myHashMap.Add(word, value);
			}
			int frequency = myHashMap.Get("be");
			Console.WriteLine("Frequency- " + frequency);
        }
    }
}
