﻿using System;
using System.Xml.Serialization;
using Assets.EVE.Scripts.XML.XMLHelper;
using UnityEngine;

namespace Assets.EVE.Scripts.XML
{
    [Serializable]
    public class UISettings
    {


        
        [XmlIgnore] public bool ManuallySetResolution; 
        
        [XmlIgnore]
        public Vector2 ReferenceResolution { get; set; }
        [XmlElement("Resolution")]
        public ReferenceResolution ResolutionToXml
        {
            get
            {
                return new ReferenceResolution
                {
                    ManuallySetResolution = ManuallySetResolution,
                    X = ReferenceResolution.x,
                    Y = ReferenceResolution.y
                };
            }
            set
            {
                ReferenceResolution = new Vector2(value.X, value.Y);
                ManuallySetResolution = value.ManuallySetResolution;
            }
        }
    }
}
