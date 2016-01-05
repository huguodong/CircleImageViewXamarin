using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"de/hdodenhof/circleimageview",
					},
					new Converter<string, Type>[]{
						lookup_de_hdodenhof_circleimageview_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_de_hdodenhof_circleimageview_mappings;
		static Type lookup_de_hdodenhof_circleimageview_package (string klass)
		{
			if (package_de_hdodenhof_circleimageview_mappings == null) {
				package_de_hdodenhof_circleimageview_mappings = new string[]{
					"de/hdodenhof/circleimageview/BuildConfig:HeadImage.CircleImageview.BuildConfig",
					"de/hdodenhof/circleimageview/CircleImageView:HeadImage.CircleImageview.Head",
					"de/hdodenhof/circleimageview/R:HeadImage.CircleImageview.R",
					"de/hdodenhof/circleimageview/R$attr:HeadImage.CircleImageview.R/Attr",
					"de/hdodenhof/circleimageview/R$styleable:HeadImage.CircleImageview.R/Styleable",
				};
			}

			return Lookup (package_de_hdodenhof_circleimageview_mappings, klass);
		}
	}
}
