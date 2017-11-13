//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Testing
{
   public partial class BaseClassWithRequiredProperties
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected BaseClassWithRequiredProperties()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_property0"></param>
      public BaseClassWithRequiredProperties(string _property0)
      {
         if (string.IsNullOrEmpty(_property0)) throw new ArgumentNullException(nameof(_property0));
         Property0 = _property0;
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_property0"></param>
      public static BaseClassWithRequiredProperties Create(string _property0)
      {
         return new BaseClassWithRequiredProperties(_property0);
      }

      // Persistent properties

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      public int Id { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      public string Property0 { get; set; }

   }
}

