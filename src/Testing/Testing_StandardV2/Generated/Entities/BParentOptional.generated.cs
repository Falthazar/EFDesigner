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
   public partial class BParentOptional
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected BParentOptional()
      {
         BChildCollection = new HashSet<BChild>();

         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_bchildrequired"></param>
      public BParentOptional(BChild _bchildrequired)
      {
         if (_bchildrequired == null) throw new ArgumentNullException(nameof(_bchildrequired));
         BChildRequired = _bchildrequired;

         BChildCollection = new HashSet<BChild>();
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_bchildrequired"></param>
      public static BParentOptional Create(BChild _bchildrequired)
      {
         return new BParentOptional(_bchildrequired);
      }

      // Persistent properties

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      public int Id { get; set; }

      // Persistent navigation properties

      public BChild BChildRequired { get; set; }  // Required
      public ICollection<BChild> BChildCollection { get; set; } 
      public BChild BChildOptional { get; set; } 
   }
}

