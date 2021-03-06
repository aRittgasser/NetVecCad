﻿using NVcad.Foundations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NVcad.Foundations.Coordinates;
using System.Windows.Controls;
using System.Globalization;
using System.Runtime.CompilerServices;
using NVcad.Foundations.Angles;

[assembly: InternalsVisibleTo("UnitTestNVcad")]
namespace NVcad.CadObjects
{
   public class Text : Graphic
   {
      public String Content { get; set; }
      public Double Height { get; set; }
      //public Double Stretch { get; set; }
      public TextJustification justification { get; set; }

      protected Text() : base() 
      {
         base.BoundingBox = new BoundingBox();
      }

      public Text(String someContent, Point aPoint) : this()
      {
         base.Origin = aPoint;
         this.Content = someContent;
         Height = 1.0;
         this.BoundingBox.expandByPoint(aPoint);
      }

      public Text(String someContent, Point aPoint, Double height)
         : this(someContent, aPoint)
      {
         Height = height;
      }

      public Text(netDxf.Entities.Text dxfText) : 
         this
         ( dxfText.Value
         , (Point) dxfText.Position
         , dxfText.Height)
      {
         this.Rotation = dxfText.Rotation;
      }

      public Text(netDxf.Entities.MText dxfMTxt) :
         this
         ( dxfMTxt.Value
         , (Point) dxfMTxt.Position
         , dxfMTxt.Height)
      {
         this.Rotation = dxfMTxt.Rotation;
      }

      //public override ToolTip GetToolTip()
      //{
      //   var result = base.GetToolTip();
      //   StringBuilder sb = new StringBuilder("Type: Text\n");
      //   sb.Append("Feature: ");
      //   sb.Append(this.Feature.Name);
      //   sb.Append("\n");
      //   sb.Append("Content: ");
      //   sb.Append(this.Content);
      //   sb.Append("\n");
      //   sb.Append("Length: ");
      //   sb.Append(this.Content.Length.ToString());
      //   result.Content = sb.ToString();
      //   return result;
      //}

   }

   public enum TextJustification
   {
      LT = 1,
      CT = 2,
      RT = 3,
      LC = 4,
      CC = 5,
      RC = 6,
      LB = 7,
      CB = 8,
      RB = 9
   }
}
