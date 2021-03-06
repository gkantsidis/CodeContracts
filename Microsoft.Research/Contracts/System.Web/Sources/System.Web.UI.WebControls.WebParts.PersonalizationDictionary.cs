// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

// File System.Web.UI.WebControls.WebParts.PersonalizationDictionary.cs
// Automatically generated contract file.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics.Contracts;
using System;

// Disable the "this variable is not used" warning as every field would imply it.
#pragma warning disable 0414
// Disable the "this variable is never assigned to".
#pragma warning disable 0067
// Disable the "this event is never assigned to".
#pragma warning disable 0649
// Disable the "this variable is never used".
#pragma warning disable 0169
// Disable the "new keyword not required" warning.
#pragma warning disable 0109
// Disable the "extern without DllImport" warning.
#pragma warning disable 0626
// Disable the "could hide other member" warning, can happen on certain properties.
#pragma warning disable 0108


namespace System.Web.UI.WebControls.WebParts
{
  public partial class PersonalizationDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
  {
    #region Methods and constructors
    public virtual new void Add(string key, PersonalizationEntry value)
    {
    }

    public virtual new void Clear()
    {
    }

    public virtual new bool Contains(string key)
    {
      return default(bool);
    }

    public virtual new void CopyTo(System.Collections.DictionaryEntry[] array, int index)
    {
    }

    public virtual new System.Collections.IDictionaryEnumerator GetEnumerator()
    {
      return default(System.Collections.IDictionaryEnumerator);
    }

    public PersonalizationDictionary(int initialSize)
    {
    }

    public PersonalizationDictionary()
    {
    }

    public virtual new void Remove(string key)
    {
    }

    void System.Collections.ICollection.CopyTo(Array array, int index)
    {
    }

    void System.Collections.IDictionary.Add(Object key, Object value)
    {
    }

    bool System.Collections.IDictionary.Contains(Object key)
    {
      return default(bool);
    }

    void System.Collections.IDictionary.Remove(Object key)
    {
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return default(System.Collections.IEnumerator);
    }
    #endregion

    #region Properties and indexers
    public virtual new int Count
    {
      get
      {
        return default(int);
      }
    }

    public virtual new bool IsFixedSize
    {
      get
      {
        return default(bool);
      }
    }

    public virtual new bool IsReadOnly
    {
      get
      {
        return default(bool);
      }
    }

    public virtual new bool IsSynchronized
    {
      get
      {
        return default(bool);
      }
    }

    public virtual new PersonalizationEntry this [string key]
    {
      get
      {
        return default(PersonalizationEntry);
      }
      set
      {
      }
    }

    public virtual new System.Collections.ICollection Keys
    {
      get
      {
        return default(System.Collections.ICollection);
      }
    }

    public virtual new Object SyncRoot
    {
      get
      {
        return default(Object);
      }
    }

    Object System.Collections.IDictionary.this [Object key]
    {
      get
      {
        return default(Object);
      }
      set
      {
      }
    }

    public virtual new System.Collections.ICollection Values
    {
      get
      {
        return default(System.Collections.ICollection);
      }
    }
    #endregion
  }
}
