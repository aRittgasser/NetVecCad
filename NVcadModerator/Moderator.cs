﻿using NVcad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

using NVcad;
using NVcad.CadObjects;

namespace NVcadModerator
{
   /// <summary>
   /// The Moderator Class is a key component of the Model-View-Moderator Pattern,
   /// a new pattern (invented by Paul Schrum in April 2014) that is in the same
   /// family as Model-View-ViewModel and Model-View-Controller.  
   /// </summary>
   /// <see cref=""/>
   public class Moderator : ICadNotificationTarget
   {
      private Canvas theCanvas { get; set; }

      // public List<ViewWindow> allViewWindows = new List<ViewWindow>();
      protected Model Model { get; set; }

      public Moderator()
      {
         Model = new Model(this);
      }

      public Moderator(Canvas aCanvas)
         : this()
      {
         this.theCanvas = aCanvas;
         Model.setUpTestingModel_20140422();
      }

      public void DrawGraphicItem(Graphic graphicItem)
      {
         int i = 0;
         i++;
      }
   }
}