//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public partial class Entity {

        public MetaIndexKeyComponent metaIndexKey { get { return (MetaIndexKeyComponent)GetComponent(MetaComponentIds.MetaIndexKey); } }

        public bool hasMetaIndexKey { get { return HasComponent(MetaComponentIds.MetaIndexKey); } }

        public Entity AddMetaIndexKey(string newName) {
            var component = CreateComponent<MetaIndexKeyComponent>(MetaComponentIds.MetaIndexKey);
            component.name = newName;
            return AddComponent(MetaComponentIds.MetaIndexKey, component);
        }

        public Entity ReplaceMetaIndexKey(string newName) {
            var component = CreateComponent<MetaIndexKeyComponent>(MetaComponentIds.MetaIndexKey);
            component.name = newName;
            ReplaceComponent(MetaComponentIds.MetaIndexKey, component);
            return this;
        }

        public Entity RemoveMetaIndexKey() {
            return RemoveComponent(MetaComponentIds.MetaIndexKey);
        }
    }
}

    public partial class MetaMatcher {

        static IMatcher _matcherMetaIndexKey;

        public static IMatcher MetaIndexKey {
            get {
                if (_matcherMetaIndexKey == null) {
                    var matcher = (Matcher)Matcher.AllOf(MetaComponentIds.MetaIndexKey);
                    matcher.componentNames = MetaComponentIds.componentNames;
                    _matcherMetaIndexKey = matcher;
                }

                return _matcherMetaIndexKey;
            }
        }
    }