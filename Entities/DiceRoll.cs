using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Entities
{
    public class DiceRoll //: BindableObject
    {
        public int NumberRolled { get; set; }
        public string ImgPath { get; set; }

        public override string ToString()
        {
            return NumberRolled+"";
        }

        //// App developers should use the method below in production code for 
        //// better performance
        //public static readonly BindableProperty BoundNameProperty =
        //     BindableProperty.Create("Foo", typeof(string),
        //                              typeof(DiceRoll),
        //                              default(string));

        //// App developers should use the method below during development for
        //// design-time error checking as the codebase evolves.
        //// public static readonly BindableProperty FooProperty 
        ////     = BindableProperty.Create<MockBindableObject, string> (
        ////         o => o.Foo, default (string)
        ////     );

        //public string BoundName
        //{
        //    get { return (string)GetValue(BoundNameProperty); }
        //    set { SetValue(BoundNameProperty, value); }
        //}
    }
}
