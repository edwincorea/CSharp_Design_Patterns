using System.Collections.Generic;

namespace Prototype
{
    /// <summary>
    /// Prototype manager
    /// </summary>
    public class ColorController
    {
        private Dictionary<string, ColorPrototype> _colors =
            new Dictionary<string, ColorPrototype>();

        // Indexer
        public ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}
