using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhat.Utility
{
    public class ListItem
    {
        public ListItem(string text, object value)
        {
            this.Text = text;
            this.Value = value;
        }

        public ListItem(string text)
        {
            this.Text = text;
            this.Value = text;
        }

        public string Text
        {
            get;
            set;
        }

        public object Value
        {
            get;
            set;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj is ListItem == false)
                return false;
            ListItem objListItem = obj as ListItem;
            if (objListItem.Text == this.Text && objListItem.Value == this.Value)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
