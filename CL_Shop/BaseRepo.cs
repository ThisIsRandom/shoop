using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CL_Shop
{
    public abstract class BaseRepo<T> where T: BaseItem
    {
        public List<T> items = new List<T>();

        public List<T> AddItem(T Item)
        {
            this.items.Add(Item);

            return this.items;
        }

        public List<T> DeleteItem(T Item)
        {
            this.items.RemoveAll((T listItem) => listItem.Id == Item.Id);

            return this.items;
        }

        public T GetItemById(int indexToSearch)
        {
            
            T Item = this.items.Find((T item) => item.Id == indexToSearch);

            if(Item == default(T))
            {
                return null;
            }

            return Item;
        }

        public List<T> GetList()
        {
            return this.items;
        }

        public bool HasItems()
        {
            return this.items.Count > 0;
        }
    }
}
