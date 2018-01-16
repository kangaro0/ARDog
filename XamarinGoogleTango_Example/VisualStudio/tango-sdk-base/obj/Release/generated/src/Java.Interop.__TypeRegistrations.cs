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
						"com/google/atap/tangoservice",
						"com/google/tango/loader",
					},
					new Converter<string, Type>[]{
						lookup_com_google_atap_tangoservice_package,
						lookup_com_google_tango_loader_package,
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

		static string[] package_com_google_atap_tangoservice_mappings;
		static Type lookup_com_google_atap_tangoservice_package (string klass)
		{
			if (package_com_google_atap_tangoservice_mappings == null) {
				package_com_google_atap_tangoservice_mappings = new string[]{
					"com/google/atap/tangoservice/ITango$Stub:Com.Google.Atap.Tangoservice.TangoStub",
					"com/google/atap/tangoservice/ITango$Stub$Proxy:Com.Google.Atap.Tangoservice.TangoStub/Proxy",
					"com/google/atap/tangoservice/ITangoListener$Stub:Com.Google.Atap.Tangoservice.TangoListenerStub",
					"com/google/atap/tangoservice/ITangoListener$Stub$Proxy:Com.Google.Atap.Tangoservice.TangoListenerStub/Proxy",
					"com/google/atap/tangoservice/ITangoVhs$Stub:Com.Google.Atap.Tangoservice.TangoVhsStub",
					"com/google/atap/tangoservice/ITangoVhs$Stub$Proxy:Com.Google.Atap.Tangoservice.TangoVhsStub/Proxy",
				};
			}

			return Lookup (package_com_google_atap_tangoservice_mappings, klass);
		}

		static string[] package_com_google_tango_loader_mappings;
		static Type lookup_com_google_tango_loader_package (string klass)
		{
			if (package_com_google_tango_loader_mappings == null) {
				package_com_google_tango_loader_mappings = new string[]{
					"com/google/tango/loader/IObjectWrapper$Stub:Com.Google.Tango.Loader.ObjectWrapperStub",
					"com/google/tango/loader/IObjectWrapper$Stub$Proxy:Com.Google.Tango.Loader.ObjectWrapperStub/Proxy",
					"com/google/tango/loader/ITangoCameraNative$Stub:Com.Google.Tango.Loader.TangoCameraNativeStub",
					"com/google/tango/loader/ITangoCameraNative$Stub$Proxy:Com.Google.Tango.Loader.TangoCameraNativeStub/Proxy",
				};
			}

			return Lookup (package_com_google_tango_loader_mappings, klass);
		}
	}
}
