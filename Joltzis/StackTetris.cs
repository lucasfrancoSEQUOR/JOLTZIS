using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joltzis {
    public class StackTetris<T> {
        public List<T> Items { get; private set; }
        public List<T> PossibleItems { get; private set; }

        public StackTetris(List<T> possibleItems) {
            Items = new List<T>();
            PossibleItems = possibleItems;
        }

        public void GenerateRandomItem() {
            Items.Add(PossibleItems[Random.Shared.Next(0, PossibleItems.Count)]);
        }

        public T Pop() {
            if (Items.Count == 0)
                return default!;

            T item = Items[0];
            Items.RemoveAt(0);

            return item;
        }

        public T GetNextItem() {
            return Items[0];
        }
    }
}


