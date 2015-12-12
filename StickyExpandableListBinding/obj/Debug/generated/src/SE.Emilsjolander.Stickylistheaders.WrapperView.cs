using System;
using System.Collections.Generic;
using Android.Runtime;

namespace SE.Emilsjolander.Stickylistheaders {

	// Metadata.xml XPath class reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='WrapperView']"
	[global::Android.Runtime.Register ("se/emilsjolander/stickylistheaders/WrapperView", DoNotGenerateAcw=true)]
	public partial class WrapperView : global::Android.Views.ViewGroup {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("se/emilsjolander/stickylistheaders/WrapperView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WrapperView); }
		}

		protected WrapperView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_hasHeader;
#pragma warning disable 0169
		static Delegate GetHasHeaderHandler ()
		{
			if (cb_hasHeader == null)
				cb_hasHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasHeader);
			return cb_hasHeader;
		}

		static bool n_HasHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.WrapperView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.WrapperView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasHeader;
		}
#pragma warning restore 0169

		static IntPtr id_hasHeader;
		public virtual unsafe bool HasHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='WrapperView']/method[@name='hasHeader' and count(parameter)=0]"
			[Register ("hasHeader", "()Z", "GetHasHeaderHandler")]
			get {
				if (id_hasHeader == IntPtr.Zero)
					id_hasHeader = JNIEnv.GetMethodID (class_ref, "hasHeader", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasHeader);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasHeader", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getHeader;
#pragma warning disable 0169
		static Delegate GetGetHeaderHandler ()
		{
			if (cb_getHeader == null)
				cb_getHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeader);
			return cb_getHeader;
		}

		static IntPtr n_GetHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.WrapperView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.WrapperView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Header);
		}
#pragma warning restore 0169

		static IntPtr id_getHeader;
		public virtual unsafe global::Android.Views.View Header {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='WrapperView']/method[@name='getHeader' and count(parameter)=0]"
			[Register ("getHeader", "()Landroid/view/View;", "GetGetHeaderHandler")]
			get {
				if (id_getHeader == IntPtr.Zero)
					id_getHeader = JNIEnv.GetMethodID (class_ref, "getHeader", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getHeader), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeader", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getItem;
#pragma warning disable 0169
		static Delegate GetGetItemHandler ()
		{
			if (cb_getItem == null)
				cb_getItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetItem);
			return cb_getItem;
		}

		static IntPtr n_GetItem (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.WrapperView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.WrapperView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Item);
		}
#pragma warning restore 0169

		static IntPtr id_getItem;
		public virtual unsafe global::Android.Views.View Item {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='WrapperView']/method[@name='getItem' and count(parameter)=0]"
			[Register ("getItem", "()Landroid/view/View;", "GetGetItemHandler")]
			get {
				if (id_getItem == IntPtr.Zero)
					id_getItem = JNIEnv.GetMethodID (class_ref, "getItem", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getItem), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2, int p3, int p4)
		{
			global::SE.Emilsjolander.Stickylistheaders.WrapperView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.WrapperView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='WrapperView']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLayout_ZIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLayout", "(ZIIII)V"), __args);
			} finally {
			}
		}

	}
}
