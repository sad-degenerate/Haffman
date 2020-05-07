using System;
using System.Collections.Generic;
using System.Linq;

namespace Haffman.BL
{
    public class Tree
    {
        public string Text { get; set; }
        Dictionary<char, int> FrequencyAlph { get; set; }
        List<Node> Source { get; set; }
        List<Node> NewAlph { get; set; }
        List<Node> _Tree { get; set; }

        public Tree(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentNullException(nameof(text), "Текст не может быть пустым.");

            Text = text;

            FrequencyAlph = new Dictionary<char, int>();
            Source = new List<Node>();
            NewAlph = new List<Node>();
            _Tree = new List<Node>();
        }

        public string Start()
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
                NewAlph.Add(new Node(pair.Key.ToString(), "", pair.Value));
                _Tree.Add(new Node(pair.Key.ToString(), "", pair.Value));
            }

            while(_Tree.Count > 1)
            {
                SortTree();

                for(int i = 0; i < Source.Count; i++)
                {
                    if (_Tree[_Tree.Count - 2].Text.Contains(Source[i].Text))
                        NewAlph[i] = new Node(NewAlph[i].Text, "0" + NewAlph[i].Code, NewAlph[i].Frequency);
                    else if (_Tree[_Tree.Count - 1].Text.Contains(Source[i].Text))
                        NewAlph[i] = new Node(NewAlph[i].Text, "1" + NewAlph[i].Code, NewAlph[i].Frequency);
                }

                _Tree[_Tree.Count - 2] = new Node(_Tree[_Tree.Count - 2].Text + _Tree[_Tree.Count - 1].Text, "",
                    _Tree[_Tree.Count - 2].Frequency + _Tree[_Tree.Count - 1].Frequency);
                _Tree.RemoveAt(_Tree.Count - 1);
            }

            var res = "";

            for (int i = 0; i < Text.Length; i++)
                foreach (var node in NewAlph)
                    if (node.Text == Text[i].ToString())
                        res += node.Code;

            return res;
        }

        private void SortTree()
        {
            for (int i = 0; i < _Tree.Count - 1; i++)
                for (int j = i; j < _Tree.Count; j++)
                    if (_Tree[i].Frequency < _Tree[j].Frequency)
                    {
                        var buff = _Tree[i];
                        _Tree[i] = _Tree[j];
                        _Tree[j] = buff;
                    }
        }
    }
}