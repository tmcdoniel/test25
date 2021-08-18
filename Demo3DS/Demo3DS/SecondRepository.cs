﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Demo3DS
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the SecondRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("8ce7688b-8501-472e-af32-661b0deaf631")]
    public partial class SecondRepository : RepoGenBaseFolder
    {
        static SecondRepository instance = new SecondRepository();

        /// <summary>
        /// Gets the singleton class instance representing the SecondRepository element repository.
        /// </summary>
        [RepositoryFolder("8ce7688b-8501-472e-af32-661b0deaf631")]
        public static SecondRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public SecondRepository() 
            : base("SecondRepository", "/", null, 0, false, "8ce7688b-8501-472e-af32-661b0deaf631", ".\\RepositoryImages\\SecondRepository8ce7688b.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("8ce7688b-8501-472e-af32-661b0deaf631")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class SecondRepositoryFolders
    {
    }
#pragma warning restore 0436
}
