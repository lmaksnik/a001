
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace AutoService.Droid.Resources.layout
{
    public class activity_layout_main : View
    {
        public activity_layout_main(Context context) :
            base(context)
        {
            Initialize();
        }

        public activity_layout_main(Context context, IAttributeSet attrs) :
            base(context, attrs)
        {
            Initialize();
        }

        public activity_layout_main(Context context, IAttributeSet attrs, int defStyle) :
            base(context, attrs, defStyle)
        {
            Initialize();
        }

        void Initialize()
        {
        }
    }
}
