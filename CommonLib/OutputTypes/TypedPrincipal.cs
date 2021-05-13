﻿using SharpHoundCommonLib.Enums;

namespace SharpHoundCommonLib.OutputTypes
{
    public class TypedPrincipal
    {
        public TypedPrincipal()
        {
            
        }
        
        public TypedPrincipal(string objectIdentifier, Label type)
        {
            ObjectIdentifier = objectIdentifier;
            ObjectType = type;
        }
        
        public string ObjectIdentifier { get; set; }
        public Label ObjectType { get; set; }
    }
}