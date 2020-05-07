using System;
using System.Collections.Generic;
using System.Linq;

namespace Haffman.BL
{
    public class Tree
    {
        public string Text { get; }
        Dictionary<char, int> FrequencyAlph { get; }
        List<Node> Source { get; }
        List<Node> ResTree { get; }
        List<Node> tree { get; }

        public Tree(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentNullException(nameof(text), "Текст не может быть пустым.");

            Text = text;

            FrequencyAlph = new Dictionary<char, int>();
            Source = new List<Node>();
            ResTree = new List<Node>();
            tree = new List<Node>();
        }

        public (string, string) Start()
        {
            for(int i = 0; i < Text.Length; i++)
            {
                if (FrequencyAlph.Keys.Contains(Text[i]))
                    FrequencyAlph[Text[i]]++;
                else
                    FrequencyAlph.Add(Text[i], 1);
            }

            foreach(var pair in FrequencyAlph)
            {
                Source.Add(new Node(pair.Key.ToString(), "", pair.Value));
                ResTree.Add(new Node(pair.Key.ToString(), "", pair.Value));
                tree.Add(new Node(pair.Key.ToString(), "", pair.Value));
            }

            while(tree.Count > 1)
            {
                SortTree();

                for(int i = 0; i < Source.Count; i++)
                {
                    if (tree[tree.Count - 2].Text.Contains(Source[i].Text))
                        ResTree[i] = new Node(ResTree[i].Text, "0" + ResTree[i].Code, ResTree[i].Frequency);
                    else if (tree[tree.Count - 1].Text.Contains(Source[i].Text))
                        ResTree[i] = new Node(ResTree[i].Text, "1" + ResTree[i].Code, ResTree[i].Frequency);
                }

                tree[tree.Count - 2] = new Node(tree[tree.Count - 2].Text + tree[tree.Count - 1].Text, "",
                    tree[tree.Count - 2].Frequency + tree[tree.Count - 1].Frequency);
                tree.RemoveAt(tree.Count - 1);
            }

            var alph = "";
            for (int i = 0; i < Source.Count; i++)
                alph += $"{ResTree[i].Text} ({ResTree[i].Code})\n";

            var res = "";

            for (int i = 0; i < Text.Length; i++)
                foreach (var node in ResTree)
                    if (node.Text == Text[i].ToString())
                        res += node.Code;

            return (res, alph);
        }

        private void SortTree()
        {
            for (int i = 0; i < tree.Count - 1; i++)
                for (int j = i; j < tree.Count; j++)
                    if (tree[i].Frequency < tree[j].Frequency)
                    {
                        var buff = tree[i];
                        tree[i] = tree[j];
                        tree[j] = buff;
                    }
        }
    }
}