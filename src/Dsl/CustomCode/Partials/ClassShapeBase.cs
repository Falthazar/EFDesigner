﻿using System.Drawing;
using Microsoft.VisualStudio.Modeling;

using Sawczyn.EFDesigner.EFModel.CustomCode.Extensions;

namespace Sawczyn.EFDesigner.EFModel
{
   public abstract partial class ClassShapeBase
   {
      private static string GetDisplayPropertyFromModelClassForAttributesCompartment(ModelElement element)
      {
         ModelAttribute attribute = (ModelAttribute)element;

         string nullable = attribute.Required ? "" : "?";
         string name = attribute.Name;
         string type = attribute.Type;
         string length = attribute.MaxLength > 0 ? $"[{attribute.MaxLength}]" : "";
         string initial = !string.IsNullOrEmpty(attribute.InitialValue) ? " = " + attribute.InitialValue : "";

         return $"{name} : {type}{nullable}{length}{initial}";
      }

      internal sealed partial class FillColorPropertyHandler
      {
         protected override void OnValueChanging(ClassShapeBase element, Color oldValue, Color newValue)
         {
            base.OnValueChanging(element, oldValue, newValue);

            if (element.Store.InUndoRedoOrRollback || element.Store.InSerializationTransaction)
               return;

            // set text color to contrasting color based on new fill color
            element.TextColor = newValue.LegibleTextColor();
         }
      }

      private bool GetVisibleValue()
      {
         return IsVisible;
      }

      private void SetVisibleValue(bool newValue)
      {
         if (newValue)
            Show();
         else
            Hide();
      }
   }
}
