using System;
using System.Collections.Generic;

namespace Treehouse.PracticeSession
{
class Item
    {
        private int _key;
        public int Key
        {
            get
            {
                return _key;
            }
           set
            {
                _key = value;
            }
        }

        private string _ItemName;

        public string ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        public Item()
        {

        }

        public Item(int key, string itemName)
        {
            this._key = key;
            this._ItemName = itemName;
        }

        public override string ToString()
        {
            return string.Format("ID: {0}; Name: {1}。",_key,_ItemName);
        }
    }
}