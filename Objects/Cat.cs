﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.jjjhhjhjhjhjhjh
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Cat.
    /// </summary>
    //  *** Start programmer edit section *** (Cat CustomAttributes)

    //  *** End programmer edit section *** (Cat CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("CatE", new string[] {
            "CatName as \'Cat name\'",
            "Weight as \'Weight\'"})]
    [AssociatedDetailViewAttribute("CatE", "Paws", "PawsE", true, "", "Paws", true, new string[] {
            ""})]
    [View("CatL", new string[] {
            "CatName as \'Cat name\'",
            "Weight as \'Weight\'"})]
    public class Cat : IIS.jjjhhjhjhjhjhjh.Animal
    {
        
        private string fCatName;
        
        private IIS.jjjhhjhjhjhjhjh.DetailArrayOfPaws fPaws;
        
        //  *** Start programmer edit section *** (Cat CustomMembers)

        //  *** End programmer edit section *** (Cat CustomMembers)

        
        /// <summary>
        /// CatName.
        /// </summary>
        //  *** Start programmer edit section *** (Cat.CatName CustomAttributes)

        //  *** End programmer edit section *** (Cat.CatName CustomAttributes)
        [StrLen(255)]
        public virtual string CatName
        {
            get
            {
                //  *** Start programmer edit section *** (Cat.CatName Get start)

                //  *** End programmer edit section *** (Cat.CatName Get start)
                string result = this.fCatName;
                //  *** Start programmer edit section *** (Cat.CatName Get end)

                //  *** End programmer edit section *** (Cat.CatName Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Cat.CatName Set start)

                //  *** End programmer edit section *** (Cat.CatName Set start)
                this.fCatName = value;
                //  *** Start programmer edit section *** (Cat.CatName Set end)

                //  *** End programmer edit section *** (Cat.CatName Set end)
            }
        }
        
        /// <summary>
        /// Cat.
        /// </summary>
        //  *** Start programmer edit section *** (Cat.Paws CustomAttributes)

        //  *** End programmer edit section *** (Cat.Paws CustomAttributes)
        public virtual IIS.jjjhhjhjhjhjhjh.DetailArrayOfPaws Paws
        {
            get
            {
                //  *** Start programmer edit section *** (Cat.Paws Get start)

                //  *** End programmer edit section *** (Cat.Paws Get start)
                if ((this.fPaws == null))
                {
                    this.fPaws = new IIS.jjjhhjhjhjhjhjh.DetailArrayOfPaws(this);
                }
                IIS.jjjhhjhjhjhjhjh.DetailArrayOfPaws result = this.fPaws;
                //  *** Start programmer edit section *** (Cat.Paws Get end)

                //  *** End programmer edit section *** (Cat.Paws Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Cat.Paws Set start)

                //  *** End programmer edit section *** (Cat.Paws Set start)
                this.fPaws = value;
                //  *** Start programmer edit section *** (Cat.Paws Set end)

                //  *** End programmer edit section *** (Cat.Paws Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "CatE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View CatE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("CatE", typeof(IIS.jjjhhjhjhjhjhjh.Cat));
                }
            }
            
            /// <summary>
            /// "CatL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View CatL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("CatL", typeof(IIS.jjjhhjhjhjhjhjh.Cat));
                }
            }
        }
    }
}
