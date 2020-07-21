using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class RandomFact : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    // Start is called before the first frame update
    void Start()
    {
        String[] facts = { "French was the official language of England for about 300 years, from 1066 to 1362.",
        "Kilts originated in France, not Scotland.",
        "With a land area of 643,801 square kilometres, France is the largest country in the EU.",
        "There are over 400 kinds of cheese made in France.",
        "France is by far the most popular tourist destination in the world, with some 82 million visitors annually.",
        "The French Army was the first to use camouflage. During World War I, artists painted vehicles and equipment to blend into their respective backgrounds.",
        "France was the first country in the world to ban supermarkets from throwing away or destroying unsold food.",
        "The most well-known bicycle race in the world, the Tour de France, began in 1903.",
        "For 214 years it was illegal in Paris for women to wear trousers. This ended in 2012.",
        "About one million French people living near the border with Italy speak Italian.",
        "At least 40 percent of the music on private radio stations must be of French origin",
        "France legalised same-sex marriage in 2013.",
        "King Louis XIX of France holds the record for the shortest ever reign, after abdicating after just 20 minutes on the throne in favour of his nephew."};

        textBox.text = facts[new System.Random().Next(0, facts.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
