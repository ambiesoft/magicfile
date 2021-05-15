using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace magicfile
{
    class OrignalFile
    {
        string _name;
        StreamReader _srNew;

        public OrignalFile() { }

        public bool IsEmpty => string.IsNullOrEmpty(_name);
        public string Name => _name;
        public void Set(string name, StreamReader sr)
        {
            _name = name;
            _srNew = sr;
        }
        public void Unlock()
        {
            if(_srNew != null)
            {
                _srNew.Close();
                _srNew = null;
            }
        }
        public void Clear()
        {
            if (_srNew != null)
            {
                _srNew.Close();
                _srNew = null;
            }
            _name = null;
        }
    }
}
