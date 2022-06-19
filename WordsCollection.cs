using System.Collections;

namespace IteratorDesignPattern
{
    class WordsCollection : IteratorAggregate
    {
        List<string> _collection = new List<string>();
        bool _direction = false;

        public void ReverseDirection() => _direction = !_direction;

        public List<string> GetItems() => _collection;

        public void AddItem(string item) => this._collection.Add(item);

        public override IEnumerator GetEnumerator() => new AlphabeticalOrderIterator(this, _direction);
    }
}