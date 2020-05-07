namespace Haffman.BL
{
    public class Node
    {
        public string Text { get; set; }
        public string Code { get; set; }
        public int Frequency { get; set; }

        public Node(string text, string code, int frequency)
        {
            Text = text;
            Code = code;
            Frequency = frequency;
        }
    }
}