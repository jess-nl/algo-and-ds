namespace Practice.Helper.Nodes
{
    public class DoublyNode
    {
        public int _val { get; }
        public DoublyNode _prev { get; set; }
        public DoublyNode _next { get; set; }

        public DoublyNode(int val)
        {
            _val = val;
            _prev = null;
            _next = null;
        }
    }
}
