using System;
using System.Collections.Generic;
using Android.Runtime;

namespace SE.Emilsjolander.Stickylistheaders {

	// Metadata.xml XPath class reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']"
	[global::Android.Runtime.Register ("se/emilsjolander/stickylistheaders/StickyListHeadersListView", DoNotGenerateAcw=true)]
	public partial class StickyListHeadersListView : global::Android.Widget.FrameLayout {

		// Metadata.xml XPath class reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView.AdapterWrapperDataSetObserver']"
		[global::Android.Runtime.Register ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$AdapterWrapperDataSetObserver", DoNotGenerateAcw=true)]
		public partial class AdapterWrapperDataSetObserver : global::Android.Database.DataSetObserver {

			protected AdapterWrapperDataSetObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView.AdapterWrapperHeaderClickHandler']"
		[global::Android.Runtime.Register ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$AdapterWrapperHeaderClickHandler", DoNotGenerateAcw=true)]
		public partial class AdapterWrapperHeaderClickHandler : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$AdapterWrapperHeaderClickHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AdapterWrapperHeaderClickHandler); }
			}

			protected AdapterWrapperHeaderClickHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onHeaderClick_Landroid_view_View_IJ;
#pragma warning disable 0169
			static Delegate GetOnHeaderClick_Landroid_view_View_IJHandler ()
			{
				if (cb_onHeaderClick_Landroid_view_View_IJ == null)
					cb_onHeaderClick_Landroid_view_View_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, long>) n_OnHeaderClick_Landroid_view_View_IJ);
				return cb_onHeaderClick_Landroid_view_View_IJ;
			}

			static void n_OnHeaderClick_Landroid_view_View_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, long p2)
			{
				global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.AdapterWrapperHeaderClickHandler __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.AdapterWrapperHeaderClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnHeaderClick (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onHeaderClick_Landroid_view_View_IJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView.AdapterWrapperHeaderClickHandler']/method[@name='onHeaderClick' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
			[Register ("onHeaderClick", "(Landroid/view/View;IJ)V", "GetOnHeaderClick_Landroid_view_View_IJHandler")]
			public virtual unsafe void OnHeaderClick (global::Android.Views.View p0, int p1, long p2)
			{
				if (id_onHeaderClick_Landroid_view_View_IJ == IntPtr.Zero)
					id_onHeaderClick_Landroid_view_View_IJ = JNIEnv.GetMethodID (class_ref, "onHeaderClick", "(Landroid/view/View;IJ)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onHeaderClick_Landroid_view_View_IJ, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHeaderClick", "(Landroid/view/View;IJ)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/interface[@name='StickyListHeadersListView.OnHeaderClickListener']"
		[Register ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$OnHeaderClickListener", "", "SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView/IOnHeaderClickListenerInvoker")]
		public partial interface IOnHeaderClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/interface[@name='StickyListHeadersListView.OnHeaderClickListener']/method[@name='onHeaderClick' and count(parameter)=5 and parameter[1][@type='se.emilsjolander.stickylistheaders.StickyListHeadersListView'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='boolean']]"
			[Register ("onHeaderClick", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersListView;Landroid/view/View;IJZ)V", "GetOnHeaderClick_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJZHandler:SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView/IOnHeaderClickListenerInvoker, StickyExpandableListBinding")]
			void OnHeaderClick (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0, global::Android.Views.View p1, int p2, long p3, bool p4);

		}

		[global::Android.Runtime.Register ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$OnHeaderClickListener", DoNotGenerateAcw=true)]
		internal class IOnHeaderClickListenerInvoker : global::Java.Lang.Object, IOnHeaderClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$OnHeaderClickListener");
			IntPtr class_ref;

			public static IOnHeaderClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnHeaderClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "se.emilsjolander.stickylistheaders.StickyListHeadersListView.OnHeaderClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnHeaderClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnHeaderClickListenerInvoker); }
			}

			static Delegate cb_onHeaderClick_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJZ;
#pragma warning disable 0169
			static Delegate GetOnHeaderClick_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJZHandler ()
			{
				if (cb_onHeaderClick_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJZ == null)
					cb_onHeaderClick_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, long, bool>) n_OnHeaderClick_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJZ);
				return cb_onHeaderClick_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJZ;
			}

			static void n_OnHeaderClick_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, long p3, bool p4)
			{
				global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnHeaderClickListener __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnHeaderClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0 = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnHeaderClick (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			IntPtr id_onHeaderClick_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJZ;
			public unsafe void OnHeaderClick (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0, global::Android.Views.View p1, int p2, long p3, bool p4)
			{
				if (id_onHeaderClick_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJZ == IntPtr.Zero)
					id_onHeaderClick_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJZ = JNIEnv.GetMethodID (class_ref, "onHeaderClick", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersListView;Landroid/view/View;IJZ)V");
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (Handle, id_onHeaderClick_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJZ, __args);
			}

		}

		public partial class HeaderClickEventArgs : global::System.EventArgs {

			public HeaderClickEventArgs (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0, global::Android.Views.View p1, int p2, long p3, bool p4)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
			}

			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0;
			public global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView P0 {
				get { return p0; }
			}

			global::Android.Views.View p1;
			public global::Android.Views.View P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}

			long p3;
			public long P3 {
				get { return p3; }
			}

			bool p4;
			public bool P4 {
				get { return p4; }
			}
		}

		[global::Android.Runtime.Register ("mono/se/emilsjolander/stickylistheaders/StickyListHeadersListView_OnHeaderClickListenerImplementor")]
		internal sealed partial class IOnHeaderClickListenerImplementor : global::Java.Lang.Object, IOnHeaderClickListener {

			object sender;

			public IOnHeaderClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/se/emilsjolander/stickylistheaders/StickyListHeadersListView_OnHeaderClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<HeaderClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnHeaderClick (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0, global::Android.Views.View p1, int p2, long p3, bool p4)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new HeaderClickEventArgs (p0, p1, p2, p3, p4));
			}

			internal static bool __IsEmpty (IOnHeaderClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/interface[@name='StickyListHeadersListView.OnStickyHeaderChangedListener']"
		[Register ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$OnStickyHeaderChangedListener", "", "SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView/IOnStickyHeaderChangedListenerInvoker")]
		public partial interface IOnStickyHeaderChangedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/interface[@name='StickyListHeadersListView.OnStickyHeaderChangedListener']/method[@name='onStickyHeaderChanged' and count(parameter)=4 and parameter[1][@type='se.emilsjolander.stickylistheaders.StickyListHeadersListView'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
			[Register ("onStickyHeaderChanged", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersListView;Landroid/view/View;IJ)V", "GetOnStickyHeaderChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJHandler:SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView/IOnStickyHeaderChangedListenerInvoker, StickyExpandableListBinding")]
			void OnStickyHeaderChanged (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0, global::Android.Views.View p1, int p2, long p3);

		}

		[global::Android.Runtime.Register ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$OnStickyHeaderChangedListener", DoNotGenerateAcw=true)]
		internal class IOnStickyHeaderChangedListenerInvoker : global::Java.Lang.Object, IOnStickyHeaderChangedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$OnStickyHeaderChangedListener");
			IntPtr class_ref;

			public static IOnStickyHeaderChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnStickyHeaderChangedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "se.emilsjolander.stickylistheaders.StickyListHeadersListView.OnStickyHeaderChangedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnStickyHeaderChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnStickyHeaderChangedListenerInvoker); }
			}

			static Delegate cb_onStickyHeaderChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJ;
#pragma warning disable 0169
			static Delegate GetOnStickyHeaderChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJHandler ()
			{
				if (cb_onStickyHeaderChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJ == null)
					cb_onStickyHeaderChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, long>) n_OnStickyHeaderChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJ);
				return cb_onStickyHeaderChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJ;
			}

			static void n_OnStickyHeaderChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, long p3)
			{
				global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderChangedListener __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0 = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnStickyHeaderChanged (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_onStickyHeaderChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJ;
			public unsafe void OnStickyHeaderChanged (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0, global::Android.Views.View p1, int p2, long p3)
			{
				if (id_onStickyHeaderChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJ == IntPtr.Zero)
					id_onStickyHeaderChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJ = JNIEnv.GetMethodID (class_ref, "onStickyHeaderChanged", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersListView;Landroid/view/View;IJ)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (Handle, id_onStickyHeaderChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IJ, __args);
			}

		}

		public partial class StickyHeaderChangedEventArgs : global::System.EventArgs {

			public StickyHeaderChangedEventArgs (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0, global::Android.Views.View p1, int p2, long p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0;
			public global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView P0 {
				get { return p0; }
			}

			global::Android.Views.View p1;
			public global::Android.Views.View P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}

			long p3;
			public long P3 {
				get { return p3; }
			}
		}

		[global::Android.Runtime.Register ("mono/se/emilsjolander/stickylistheaders/StickyListHeadersListView_OnStickyHeaderChangedListenerImplementor")]
		internal sealed partial class IOnStickyHeaderChangedListenerImplementor : global::Java.Lang.Object, IOnStickyHeaderChangedListener {

			object sender;

			public IOnStickyHeaderChangedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/se/emilsjolander/stickylistheaders/StickyListHeadersListView_OnStickyHeaderChangedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<StickyHeaderChangedEventArgs> Handler;
#pragma warning restore 0649

			public void OnStickyHeaderChanged (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0, global::Android.Views.View p1, int p2, long p3)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new StickyHeaderChangedEventArgs (p0, p1, p2, p3));
			}

			internal static bool __IsEmpty (IOnStickyHeaderChangedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/interface[@name='StickyListHeadersListView.OnStickyHeaderOffsetChangedListener']"
		[Register ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$OnStickyHeaderOffsetChangedListener", "", "SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView/IOnStickyHeaderOffsetChangedListenerInvoker")]
		public partial interface IOnStickyHeaderOffsetChangedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/interface[@name='StickyListHeadersListView.OnStickyHeaderOffsetChangedListener']/method[@name='onStickyHeaderOffsetChanged' and count(parameter)=3 and parameter[1][@type='se.emilsjolander.stickylistheaders.StickyListHeadersListView'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int']]"
			[Register ("onStickyHeaderOffsetChanged", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersListView;Landroid/view/View;I)V", "GetOnStickyHeaderOffsetChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IHandler:SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView/IOnStickyHeaderOffsetChangedListenerInvoker, StickyExpandableListBinding")]
			void OnStickyHeaderOffsetChanged (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0, global::Android.Views.View p1, int p2);

		}

		[global::Android.Runtime.Register ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$OnStickyHeaderOffsetChangedListener", DoNotGenerateAcw=true)]
		internal class IOnStickyHeaderOffsetChangedListenerInvoker : global::Java.Lang.Object, IOnStickyHeaderOffsetChangedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$OnStickyHeaderOffsetChangedListener");
			IntPtr class_ref;

			public static IOnStickyHeaderOffsetChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnStickyHeaderOffsetChangedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "se.emilsjolander.stickylistheaders.StickyListHeadersListView.OnStickyHeaderOffsetChangedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnStickyHeaderOffsetChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnStickyHeaderOffsetChangedListenerInvoker); }
			}

			static Delegate cb_onStickyHeaderOffsetChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_I;
#pragma warning disable 0169
			static Delegate GetOnStickyHeaderOffsetChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_IHandler ()
			{
				if (cb_onStickyHeaderOffsetChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_I == null)
					cb_onStickyHeaderOffsetChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_OnStickyHeaderOffsetChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_I);
				return cb_onStickyHeaderOffsetChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_I;
			}

			static void n_OnStickyHeaderOffsetChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
			{
				global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderOffsetChangedListener __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderOffsetChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0 = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnStickyHeaderOffsetChanged (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onStickyHeaderOffsetChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_I;
			public unsafe void OnStickyHeaderOffsetChanged (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0, global::Android.Views.View p1, int p2)
			{
				if (id_onStickyHeaderOffsetChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_I == IntPtr.Zero)
					id_onStickyHeaderOffsetChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "onStickyHeaderOffsetChanged", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersListView;Landroid/view/View;I)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (Handle, id_onStickyHeaderOffsetChanged_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_Landroid_view_View_I, __args);
			}

		}

		public partial class StickyHeaderOffsetChangedEventArgs : global::System.EventArgs {

			public StickyHeaderOffsetChangedEventArgs (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0, global::Android.Views.View p1, int p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0;
			public global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView P0 {
				get { return p0; }
			}

			global::Android.Views.View p1;
			public global::Android.Views.View P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/se/emilsjolander/stickylistheaders/StickyListHeadersListView_OnStickyHeaderOffsetChangedListenerImplementor")]
		internal sealed partial class IOnStickyHeaderOffsetChangedListenerImplementor : global::Java.Lang.Object, IOnStickyHeaderOffsetChangedListener {

			object sender;

			public IOnStickyHeaderOffsetChangedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/se/emilsjolander/stickylistheaders/StickyListHeadersListView_OnStickyHeaderOffsetChangedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<StickyHeaderOffsetChangedEventArgs> Handler;
#pragma warning restore 0649

			public void OnStickyHeaderOffsetChanged (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView p0, global::Android.Views.View p1, int p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new StickyHeaderOffsetChangedEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IOnStickyHeaderOffsetChangedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView.WrapperListScrollListener']"
		[global::Android.Runtime.Register ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$WrapperListScrollListener", DoNotGenerateAcw=true)]
		public partial class WrapperListScrollListener : global::Java.Lang.Object, global::Android.Widget.AbsListView.IOnScrollListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$WrapperListScrollListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WrapperListScrollListener); }
			}

			protected WrapperListScrollListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onScroll_Landroid_widget_AbsListView_III;
#pragma warning disable 0169
			static Delegate GetOnScroll_Landroid_widget_AbsListView_IIIHandler ()
			{
				if (cb_onScroll_Landroid_widget_AbsListView_III == null)
					cb_onScroll_Landroid_widget_AbsListView_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnScroll_Landroid_widget_AbsListView_III);
				return cb_onScroll_Landroid_widget_AbsListView_III;
			}

			static void n_OnScroll_Landroid_widget_AbsListView_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
			{
				global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.WrapperListScrollListener __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.WrapperListScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnScroll (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onScroll_Landroid_widget_AbsListView_III;
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView.WrapperListScrollListener']/method[@name='onScroll' and count(parameter)=4 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onScroll", "(Landroid/widget/AbsListView;III)V", "GetOnScroll_Landroid_widget_AbsListView_IIIHandler")]
			public virtual unsafe void OnScroll (global::Android.Widget.AbsListView p0, int p1, int p2, int p3)
			{
				if (id_onScroll_Landroid_widget_AbsListView_III == IntPtr.Zero)
					id_onScroll_Landroid_widget_AbsListView_III = JNIEnv.GetMethodID (class_ref, "onScroll", "(Landroid/widget/AbsListView;III)V");
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onScroll_Landroid_widget_AbsListView_III, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScroll", "(Landroid/widget/AbsListView;III)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
#pragma warning disable 0169
			static Delegate GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler ()
			{
				if (cb_onScrollStateChanged_Landroid_widget_AbsListView_I == null)
					cb_onScrollStateChanged_Landroid_widget_AbsListView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnScrollStateChanged_Landroid_widget_AbsListView_I);
				return cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
			}

			static void n_OnScrollStateChanged_Landroid_widget_AbsListView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
			{
				global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.WrapperListScrollListener __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.WrapperListScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.ScrollState p1 = (global::Android.Widget.ScrollState) native_p1;
				__this.OnScrollStateChanged (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onScrollStateChanged_Landroid_widget_AbsListView_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView.WrapperListScrollListener']/method[@name='onScrollStateChanged' and count(parameter)=2 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int']]"
			[Register ("onScrollStateChanged", "(Landroid/widget/AbsListView;I)V", "GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler")]
			public virtual unsafe void OnScrollStateChanged (global::Android.Widget.AbsListView p0, [global::Android.Runtime.GeneratedEnum] global::Android.Widget.ScrollState p1)
			{
				if (id_onScrollStateChanged_Landroid_widget_AbsListView_I == IntPtr.Zero)
					id_onScrollStateChanged_Landroid_widget_AbsListView_I = JNIEnv.GetMethodID (class_ref, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue ((int) p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onScrollStateChanged_Landroid_widget_AbsListView_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView.WrapperViewListLifeCycleListener']"
		[global::Android.Runtime.Register ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$WrapperViewListLifeCycleListener", DoNotGenerateAcw=true)]
		public partial class WrapperViewListLifeCycleListener : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("se/emilsjolander/stickylistheaders/StickyListHeadersListView$WrapperViewListLifeCycleListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WrapperViewListLifeCycleListener); }
			}

			protected WrapperViewListLifeCycleListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onDispatchDrawOccurred_Landroid_graphics_Canvas_;
#pragma warning disable 0169
			static Delegate GetOnDispatchDrawOccurred_Landroid_graphics_Canvas_Handler ()
			{
				if (cb_onDispatchDrawOccurred_Landroid_graphics_Canvas_ == null)
					cb_onDispatchDrawOccurred_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDispatchDrawOccurred_Landroid_graphics_Canvas_);
				return cb_onDispatchDrawOccurred_Landroid_graphics_Canvas_;
			}

			static void n_OnDispatchDrawOccurred_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.WrapperViewListLifeCycleListener __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.WrapperViewListLifeCycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDispatchDrawOccurred (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onDispatchDrawOccurred_Landroid_graphics_Canvas_;
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView.WrapperViewListLifeCycleListener']/method[@name='onDispatchDrawOccurred' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
			[Register ("onDispatchDrawOccurred", "(Landroid/graphics/Canvas;)V", "GetOnDispatchDrawOccurred_Landroid_graphics_Canvas_Handler")]
			public virtual unsafe void OnDispatchDrawOccurred (global::Android.Graphics.Canvas p0)
			{
				if (id_onDispatchDrawOccurred_Landroid_graphics_Canvas_ == IntPtr.Zero)
					id_onDispatchDrawOccurred_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "onDispatchDrawOccurred", "(Landroid/graphics/Canvas;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onDispatchDrawOccurred_Landroid_graphics_Canvas_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDispatchDrawOccurred", "(Landroid/graphics/Canvas;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("se/emilsjolander/stickylistheaders/StickyListHeadersListView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StickyListHeadersListView); }
		}

		protected StickyListHeadersListView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/constructor[@name='StickyListHeadersListView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe StickyListHeadersListView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (StickyListHeadersListView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/constructor[@name='StickyListHeadersListView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe StickyListHeadersListView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (StickyListHeadersListView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/constructor[@name='StickyListHeadersListView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe StickyListHeadersListView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (StickyListHeadersListView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getAdapter;
#pragma warning disable 0169
		static Delegate GetGetAdapterHandler ()
		{
			if (cb_getAdapter == null)
				cb_getAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdapter);
			return cb_getAdapter;
		}

		static IntPtr n_GetAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Adapter);
		}
#pragma warning restore 0169

		static Delegate cb_setAdapter_Lse_emilsjolander_stickylistheaders_StickyListHeadersAdapter_;
#pragma warning disable 0169
		static Delegate GetSetAdapter_Lse_emilsjolander_stickylistheaders_StickyListHeadersAdapter_Handler ()
		{
			if (cb_setAdapter_Lse_emilsjolander_stickylistheaders_StickyListHeadersAdapter_ == null)
				cb_setAdapter_Lse_emilsjolander_stickylistheaders_StickyListHeadersAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdapter_Lse_emilsjolander_stickylistheaders_StickyListHeadersAdapter_);
			return cb_setAdapter_Lse_emilsjolander_stickylistheaders_StickyListHeadersAdapter_;
		}

		static void n_SetAdapter_Lse_emilsjolander_stickylistheaders_StickyListHeadersAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter p0 = (global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter)global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Adapter = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAdapter;
		static IntPtr id_setAdapter_Lse_emilsjolander_stickylistheaders_StickyListHeadersAdapter_;
		public virtual unsafe global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter Adapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getAdapter' and count(parameter)=0]"
			[Register ("getAdapter", "()Lse/emilsjolander/stickylistheaders/StickyListHeadersAdapter;", "GetGetAdapterHandler")]
			get {
				if (id_getAdapter == IntPtr.Zero)
					id_getAdapter = JNIEnv.GetMethodID (class_ref, "getAdapter", "()Lse/emilsjolander/stickylistheaders/StickyListHeadersAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (JNIEnv.CallObjectMethod  (Handle, id_getAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdapter", "()Lse/emilsjolander/stickylistheaders/StickyListHeadersAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setAdapter' and count(parameter)=1 and parameter[1][@type='se.emilsjolander.stickylistheaders.StickyListHeadersAdapter']]"
			[Register ("setAdapter", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersAdapter;)V", "GetSetAdapter_Lse_emilsjolander_stickylistheaders_StickyListHeadersAdapter_Handler")]
			set {
				if (id_setAdapter_Lse_emilsjolander_stickylistheaders_StickyListHeadersAdapter_ == IntPtr.Zero)
					id_setAdapter_Lse_emilsjolander_stickylistheaders_StickyListHeadersAdapter_ = JNIEnv.GetMethodID (class_ref, "setAdapter", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersAdapter;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAdapter_Lse_emilsjolander_stickylistheaders_StickyListHeadersAdapter_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdapter", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersAdapter;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAreHeadersSticky;
#pragma warning disable 0169
		static Delegate GetGetAreHeadersStickyHandler ()
		{
			if (cb_getAreHeadersSticky == null)
				cb_getAreHeadersSticky = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAreHeadersSticky);
			return cb_getAreHeadersSticky;
		}

		static bool n_GetAreHeadersSticky (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AreHeadersSticky;
		}
#pragma warning restore 0169

		static Delegate cb_setAreHeadersSticky_Z;
#pragma warning disable 0169
		static Delegate GetSetAreHeadersSticky_ZHandler ()
		{
			if (cb_setAreHeadersSticky_Z == null)
				cb_setAreHeadersSticky_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAreHeadersSticky_Z);
			return cb_setAreHeadersSticky_Z;
		}

		static void n_SetAreHeadersSticky_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AreHeadersSticky = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAreHeadersSticky;
		static IntPtr id_setAreHeadersSticky_Z;
		public virtual unsafe bool AreHeadersSticky {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getAreHeadersSticky' and count(parameter)=0]"
			[Register ("getAreHeadersSticky", "()Z", "GetGetAreHeadersStickyHandler")]
			get {
				if (id_getAreHeadersSticky == IntPtr.Zero)
					id_getAreHeadersSticky = JNIEnv.GetMethodID (class_ref, "getAreHeadersSticky", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getAreHeadersSticky);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAreHeadersSticky", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setAreHeadersSticky' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAreHeadersSticky", "(Z)V", "GetSetAreHeadersSticky_ZHandler")]
			set {
				if (id_setAreHeadersSticky_Z == IntPtr.Zero)
					id_setAreHeadersSticky_Z = JNIEnv.GetMethodID (class_ref, "setAreHeadersSticky", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAreHeadersSticky_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAreHeadersSticky", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCheckedItemCount;
#pragma warning disable 0169
		static Delegate GetGetCheckedItemCountHandler ()
		{
			if (cb_getCheckedItemCount == null)
				cb_getCheckedItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCheckedItemCount);
			return cb_getCheckedItemCount;
		}

		static int n_GetCheckedItemCount (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckedItemCount;
		}
#pragma warning restore 0169

		static IntPtr id_getCheckedItemCount;
		public virtual unsafe int CheckedItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getCheckedItemCount' and count(parameter)=0]"
			[Register ("getCheckedItemCount", "()I", "GetGetCheckedItemCountHandler")]
			get {
				if (id_getCheckedItemCount == IntPtr.Zero)
					id_getCheckedItemCount = JNIEnv.GetMethodID (class_ref, "getCheckedItemCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCheckedItemCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCheckedItemCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCheckedItemPosition;
#pragma warning disable 0169
		static Delegate GetGetCheckedItemPositionHandler ()
		{
			if (cb_getCheckedItemPosition == null)
				cb_getCheckedItemPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCheckedItemPosition);
			return cb_getCheckedItemPosition;
		}

		static int n_GetCheckedItemPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckedItemPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getCheckedItemPosition;
		public virtual unsafe int CheckedItemPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getCheckedItemPosition' and count(parameter)=0]"
			[Register ("getCheckedItemPosition", "()I", "GetGetCheckedItemPositionHandler")]
			get {
				if (id_getCheckedItemPosition == IntPtr.Zero)
					id_getCheckedItemPosition = JNIEnv.GetMethodID (class_ref, "getCheckedItemPosition", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCheckedItemPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCheckedItemPosition", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCheckedItemPositions;
#pragma warning disable 0169
		static Delegate GetGetCheckedItemPositionsHandler ()
		{
			if (cb_getCheckedItemPositions == null)
				cb_getCheckedItemPositions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCheckedItemPositions);
			return cb_getCheckedItemPositions;
		}

		static IntPtr n_GetCheckedItemPositions (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CheckedItemPositions);
		}
#pragma warning restore 0169

		static IntPtr id_getCheckedItemPositions;
		public virtual unsafe global::Android.Util.SparseBooleanArray CheckedItemPositions {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getCheckedItemPositions' and count(parameter)=0]"
			[Register ("getCheckedItemPositions", "()Landroid/util/SparseBooleanArray;", "GetGetCheckedItemPositionsHandler")]
			get {
				if (id_getCheckedItemPositions == IntPtr.Zero)
					id_getCheckedItemPositions = JNIEnv.GetMethodID (class_ref, "getCheckedItemPositions", "()Landroid/util/SparseBooleanArray;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Util.SparseBooleanArray> (JNIEnv.CallObjectMethod  (Handle, id_getCheckedItemPositions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Util.SparseBooleanArray> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCheckedItemPositions", "()Landroid/util/SparseBooleanArray;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public virtual unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDivider;
#pragma warning disable 0169
		static Delegate GetGetDividerHandler ()
		{
			if (cb_getDivider == null)
				cb_getDivider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDivider);
			return cb_getDivider;
		}

		static IntPtr n_GetDivider (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Divider);
		}
#pragma warning restore 0169

		static Delegate cb_setDivider_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetDivider_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setDivider_Landroid_graphics_drawable_Drawable_ == null)
				cb_setDivider_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDivider_Landroid_graphics_drawable_Drawable_);
			return cb_setDivider_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetDivider_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Divider = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDivider;
		static IntPtr id_setDivider_Landroid_graphics_drawable_Drawable_;
		public virtual unsafe global::Android.Graphics.Drawables.Drawable Divider {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getDivider' and count(parameter)=0]"
			[Register ("getDivider", "()Landroid/graphics/drawable/Drawable;", "GetGetDividerHandler")]
			get {
				if (id_getDivider == IntPtr.Zero)
					id_getDivider = JNIEnv.GetMethodID (class_ref, "getDivider", "()Landroid/graphics/drawable/Drawable;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getDivider), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDivider", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setDivider' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setDivider", "(Landroid/graphics/drawable/Drawable;)V", "GetSetDivider_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				if (id_setDivider_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_setDivider_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setDivider", "(Landroid/graphics/drawable/Drawable;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDivider_Landroid_graphics_drawable_Drawable_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDivider", "(Landroid/graphics/drawable/Drawable;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDividerHeight;
#pragma warning disable 0169
		static Delegate GetGetDividerHeightHandler ()
		{
			if (cb_getDividerHeight == null)
				cb_getDividerHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDividerHeight);
			return cb_getDividerHeight;
		}

		static int n_GetDividerHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DividerHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setDividerHeight_I;
#pragma warning disable 0169
		static Delegate GetSetDividerHeight_IHandler ()
		{
			if (cb_setDividerHeight_I == null)
				cb_setDividerHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDividerHeight_I);
			return cb_setDividerHeight_I;
		}

		static void n_SetDividerHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DividerHeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDividerHeight;
		static IntPtr id_setDividerHeight_I;
		public virtual unsafe int DividerHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getDividerHeight' and count(parameter)=0]"
			[Register ("getDividerHeight", "()I", "GetGetDividerHeightHandler")]
			get {
				if (id_getDividerHeight == IntPtr.Zero)
					id_getDividerHeight = JNIEnv.GetMethodID (class_ref, "getDividerHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDividerHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDividerHeight", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setDividerHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDividerHeight", "(I)V", "GetSetDividerHeight_IHandler")]
			set {
				if (id_setDividerHeight_I == IntPtr.Zero)
					id_setDividerHeight_I = JNIEnv.GetMethodID (class_ref, "setDividerHeight", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDividerHeight_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDividerHeight", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDrawingListUnderStickyHeader;
#pragma warning disable 0169
		static Delegate GetIsDrawingListUnderStickyHeaderHandler ()
		{
			if (cb_isDrawingListUnderStickyHeader == null)
				cb_isDrawingListUnderStickyHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawingListUnderStickyHeader);
			return cb_isDrawingListUnderStickyHeader;
		}

		static bool n_IsDrawingListUnderStickyHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DrawingListUnderStickyHeader;
		}
#pragma warning restore 0169

		static Delegate cb_setDrawingListUnderStickyHeader_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawingListUnderStickyHeader_ZHandler ()
		{
			if (cb_setDrawingListUnderStickyHeader_Z == null)
				cb_setDrawingListUnderStickyHeader_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawingListUnderStickyHeader_Z);
			return cb_setDrawingListUnderStickyHeader_Z;
		}

		static void n_SetDrawingListUnderStickyHeader_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrawingListUnderStickyHeader = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDrawingListUnderStickyHeader;
		static IntPtr id_setDrawingListUnderStickyHeader_Z;
		public virtual unsafe bool DrawingListUnderStickyHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='isDrawingListUnderStickyHeader' and count(parameter)=0]"
			[Register ("isDrawingListUnderStickyHeader", "()Z", "GetIsDrawingListUnderStickyHeaderHandler")]
			get {
				if (id_isDrawingListUnderStickyHeader == IntPtr.Zero)
					id_isDrawingListUnderStickyHeader = JNIEnv.GetMethodID (class_ref, "isDrawingListUnderStickyHeader", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDrawingListUnderStickyHeader);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDrawingListUnderStickyHeader", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setDrawingListUnderStickyHeader' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDrawingListUnderStickyHeader", "(Z)V", "GetSetDrawingListUnderStickyHeader_ZHandler")]
			set {
				if (id_setDrawingListUnderStickyHeader_Z == IntPtr.Zero)
					id_setDrawingListUnderStickyHeader_Z = JNIEnv.GetMethodID (class_ref, "setDrawingListUnderStickyHeader", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDrawingListUnderStickyHeader_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDrawingListUnderStickyHeader", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEmptyView;
#pragma warning disable 0169
		static Delegate GetGetEmptyViewHandler ()
		{
			if (cb_getEmptyView == null)
				cb_getEmptyView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmptyView);
			return cb_getEmptyView;
		}

		static IntPtr n_GetEmptyView (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EmptyView);
		}
#pragma warning restore 0169

		static Delegate cb_setEmptyView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetEmptyView_Landroid_view_View_Handler ()
		{
			if (cb_setEmptyView_Landroid_view_View_ == null)
				cb_setEmptyView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmptyView_Landroid_view_View_);
			return cb_setEmptyView_Landroid_view_View_;
		}

		static void n_SetEmptyView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmptyView = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmptyView;
		static IntPtr id_setEmptyView_Landroid_view_View_;
		public virtual unsafe global::Android.Views.View EmptyView {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getEmptyView' and count(parameter)=0]"
			[Register ("getEmptyView", "()Landroid/view/View;", "GetGetEmptyViewHandler")]
			get {
				if (id_getEmptyView == IntPtr.Zero)
					id_getEmptyView = JNIEnv.GetMethodID (class_ref, "getEmptyView", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getEmptyView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmptyView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setEmptyView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setEmptyView", "(Landroid/view/View;)V", "GetSetEmptyView_Landroid_view_View_Handler")]
			set {
				if (id_setEmptyView_Landroid_view_View_ == IntPtr.Zero)
					id_setEmptyView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setEmptyView", "(Landroid/view/View;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setEmptyView_Landroid_view_View_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmptyView", "(Landroid/view/View;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isFastScrollAlwaysVisible;
#pragma warning disable 0169
		static Delegate GetIsFastScrollAlwaysVisibleHandler ()
		{
			if (cb_isFastScrollAlwaysVisible == null)
				cb_isFastScrollAlwaysVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFastScrollAlwaysVisible);
			return cb_isFastScrollAlwaysVisible;
		}

		static bool n_IsFastScrollAlwaysVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FastScrollAlwaysVisible;
		}
#pragma warning restore 0169

		static Delegate cb_setFastScrollAlwaysVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetFastScrollAlwaysVisible_ZHandler ()
		{
			if (cb_setFastScrollAlwaysVisible_Z == null)
				cb_setFastScrollAlwaysVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFastScrollAlwaysVisible_Z);
			return cb_setFastScrollAlwaysVisible_Z;
		}

		static void n_SetFastScrollAlwaysVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FastScrollAlwaysVisible = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isFastScrollAlwaysVisible;
		static IntPtr id_setFastScrollAlwaysVisible_Z;
		public virtual unsafe bool FastScrollAlwaysVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='isFastScrollAlwaysVisible' and count(parameter)=0]"
			[Register ("isFastScrollAlwaysVisible", "()Z", "GetIsFastScrollAlwaysVisibleHandler")]
			get {
				if (id_isFastScrollAlwaysVisible == IntPtr.Zero)
					id_isFastScrollAlwaysVisible = JNIEnv.GetMethodID (class_ref, "isFastScrollAlwaysVisible", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isFastScrollAlwaysVisible);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFastScrollAlwaysVisible", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setFastScrollAlwaysVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFastScrollAlwaysVisible", "(Z)V", "GetSetFastScrollAlwaysVisible_ZHandler")]
			set {
				if (id_setFastScrollAlwaysVisible_Z == IntPtr.Zero)
					id_setFastScrollAlwaysVisible_Z = JNIEnv.GetMethodID (class_ref, "setFastScrollAlwaysVisible", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFastScrollAlwaysVisible_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFastScrollAlwaysVisible", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFirstVisiblePosition;
#pragma warning disable 0169
		static Delegate GetGetFirstVisiblePositionHandler ()
		{
			if (cb_getFirstVisiblePosition == null)
				cb_getFirstVisiblePosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFirstVisiblePosition);
			return cb_getFirstVisiblePosition;
		}

		static int n_GetFirstVisiblePosition (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FirstVisiblePosition;
		}
#pragma warning restore 0169

		static IntPtr id_getFirstVisiblePosition;
		public virtual unsafe int FirstVisiblePosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getFirstVisiblePosition' and count(parameter)=0]"
			[Register ("getFirstVisiblePosition", "()I", "GetGetFirstVisiblePositionHandler")]
			get {
				if (id_getFirstVisiblePosition == IntPtr.Zero)
					id_getFirstVisiblePosition = JNIEnv.GetMethodID (class_ref, "getFirstVisiblePosition", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getFirstVisiblePosition);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstVisiblePosition", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFooterViewsCount;
#pragma warning disable 0169
		static Delegate GetGetFooterViewsCountHandler ()
		{
			if (cb_getFooterViewsCount == null)
				cb_getFooterViewsCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFooterViewsCount);
			return cb_getFooterViewsCount;
		}

		static int n_GetFooterViewsCount (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FooterViewsCount;
		}
#pragma warning restore 0169

		static IntPtr id_getFooterViewsCount;
		public virtual unsafe int FooterViewsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getFooterViewsCount' and count(parameter)=0]"
			[Register ("getFooterViewsCount", "()I", "GetGetFooterViewsCountHandler")]
			get {
				if (id_getFooterViewsCount == IntPtr.Zero)
					id_getFooterViewsCount = JNIEnv.GetMethodID (class_ref, "getFooterViewsCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getFooterViewsCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFooterViewsCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderViewsCount;
#pragma warning disable 0169
		static Delegate GetGetHeaderViewsCountHandler ()
		{
			if (cb_getHeaderViewsCount == null)
				cb_getHeaderViewsCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeaderViewsCount);
			return cb_getHeaderViewsCount;
		}

		static int n_GetHeaderViewsCount (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderViewsCount;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderViewsCount;
		public virtual unsafe int HeaderViewsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getHeaderViewsCount' and count(parameter)=0]"
			[Register ("getHeaderViewsCount", "()I", "GetGetHeaderViewsCountHandler")]
			get {
				if (id_getHeaderViewsCount == IntPtr.Zero)
					id_getHeaderViewsCount = JNIEnv.GetMethodID (class_ref, "getHeaderViewsCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHeaderViewsCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaderViewsCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getLastVisiblePosition;
#pragma warning disable 0169
		static Delegate GetGetLastVisiblePositionHandler ()
		{
			if (cb_getLastVisiblePosition == null)
				cb_getLastVisiblePosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLastVisiblePosition);
			return cb_getLastVisiblePosition;
		}

		static int n_GetLastVisiblePosition (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastVisiblePosition;
		}
#pragma warning restore 0169

		static IntPtr id_getLastVisiblePosition;
		public virtual unsafe int LastVisiblePosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getLastVisiblePosition' and count(parameter)=0]"
			[Register ("getLastVisiblePosition", "()I", "GetGetLastVisiblePositionHandler")]
			get {
				if (id_getLastVisiblePosition == IntPtr.Zero)
					id_getLastVisiblePosition = JNIEnv.GetMethodID (class_ref, "getLastVisiblePosition", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getLastVisiblePosition);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastVisiblePosition", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getListChildCount;
#pragma warning disable 0169
		static Delegate GetGetListChildCountHandler ()
		{
			if (cb_getListChildCount == null)
				cb_getListChildCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetListChildCount);
			return cb_getListChildCount;
		}

		static int n_GetListChildCount (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ListChildCount;
		}
#pragma warning restore 0169

		static IntPtr id_getListChildCount;
		public virtual unsafe int ListChildCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getListChildCount' and count(parameter)=0]"
			[Register ("getListChildCount", "()I", "GetGetListChildCountHandler")]
			get {
				if (id_getListChildCount == IntPtr.Zero)
					id_getListChildCount = JNIEnv.GetMethodID (class_ref, "getListChildCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getListChildCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListChildCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isStackFromBottom;
#pragma warning disable 0169
		static Delegate GetIsStackFromBottomHandler ()
		{
			if (cb_isStackFromBottom == null)
				cb_isStackFromBottom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStackFromBottom);
			return cb_isStackFromBottom;
		}

		static bool n_IsStackFromBottom (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StackFromBottom;
		}
#pragma warning restore 0169

		static Delegate cb_setStackFromBottom_Z;
#pragma warning disable 0169
		static Delegate GetSetStackFromBottom_ZHandler ()
		{
			if (cb_setStackFromBottom_Z == null)
				cb_setStackFromBottom_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetStackFromBottom_Z);
			return cb_setStackFromBottom_Z;
		}

		static void n_SetStackFromBottom_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StackFromBottom = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isStackFromBottom;
		static IntPtr id_setStackFromBottom_Z;
		public virtual unsafe bool StackFromBottom {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='isStackFromBottom' and count(parameter)=0]"
			[Register ("isStackFromBottom", "()Z", "GetIsStackFromBottomHandler")]
			get {
				if (id_isStackFromBottom == IntPtr.Zero)
					id_isStackFromBottom = JNIEnv.GetMethodID (class_ref, "isStackFromBottom", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isStackFromBottom);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStackFromBottom", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setStackFromBottom' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStackFromBottom", "(Z)V", "GetSetStackFromBottom_ZHandler")]
			set {
				if (id_setStackFromBottom_Z == IntPtr.Zero)
					id_setStackFromBottom_Z = JNIEnv.GetMethodID (class_ref, "setStackFromBottom", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setStackFromBottom_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStackFromBottom", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStickyHeaderTopOffset;
#pragma warning disable 0169
		static Delegate GetGetStickyHeaderTopOffsetHandler ()
		{
			if (cb_getStickyHeaderTopOffset == null)
				cb_getStickyHeaderTopOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStickyHeaderTopOffset);
			return cb_getStickyHeaderTopOffset;
		}

		static int n_GetStickyHeaderTopOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StickyHeaderTopOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setStickyHeaderTopOffset_I;
#pragma warning disable 0169
		static Delegate GetSetStickyHeaderTopOffset_IHandler ()
		{
			if (cb_setStickyHeaderTopOffset_I == null)
				cb_setStickyHeaderTopOffset_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStickyHeaderTopOffset_I);
			return cb_setStickyHeaderTopOffset_I;
		}

		static void n_SetStickyHeaderTopOffset_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StickyHeaderTopOffset = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStickyHeaderTopOffset;
		static IntPtr id_setStickyHeaderTopOffset_I;
		public virtual unsafe int StickyHeaderTopOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getStickyHeaderTopOffset' and count(parameter)=0]"
			[Register ("getStickyHeaderTopOffset", "()I", "GetGetStickyHeaderTopOffsetHandler")]
			get {
				if (id_getStickyHeaderTopOffset == IntPtr.Zero)
					id_getStickyHeaderTopOffset = JNIEnv.GetMethodID (class_ref, "getStickyHeaderTopOffset", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getStickyHeaderTopOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStickyHeaderTopOffset", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setStickyHeaderTopOffset' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStickyHeaderTopOffset", "(I)V", "GetSetStickyHeaderTopOffset_IHandler")]
			set {
				if (id_setStickyHeaderTopOffset_I == IntPtr.Zero)
					id_setStickyHeaderTopOffset_I = JNIEnv.GetMethodID (class_ref, "setStickyHeaderTopOffset", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setStickyHeaderTopOffset_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStickyHeaderTopOffset", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWrappedList;
#pragma warning disable 0169
		static Delegate GetGetWrappedListHandler ()
		{
			if (cb_getWrappedList == null)
				cb_getWrappedList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWrappedList);
			return cb_getWrappedList;
		}

		static IntPtr n_GetWrappedList (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WrappedList);
		}
#pragma warning restore 0169

		static IntPtr id_getWrappedList;
		public virtual unsafe global::Android.Widget.ListView WrappedList {
			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getWrappedList' and count(parameter)=0]"
			[Register ("getWrappedList", "()Landroid/widget/ListView;", "GetGetWrappedListHandler")]
			get {
				if (id_getWrappedList == IntPtr.Zero)
					id_getWrappedList = JNIEnv.GetMethodID (class_ref, "getWrappedList", "()Landroid/widget/ListView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ListView> (JNIEnv.CallObjectMethod  (Handle, id_getWrappedList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ListView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWrappedList", "()Landroid/widget/ListView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addFooterView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetAddFooterView_Landroid_view_View_Handler ()
		{
			if (cb_addFooterView_Landroid_view_View_ == null)
				cb_addFooterView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFooterView_Landroid_view_View_);
			return cb_addFooterView_Landroid_view_View_;
		}

		static void n_AddFooterView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddFooterView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addFooterView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='addFooterView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("addFooterView", "(Landroid/view/View;)V", "GetAddFooterView_Landroid_view_View_Handler")]
		public virtual unsafe void AddFooterView (global::Android.Views.View p0)
		{
			if (id_addFooterView_Landroid_view_View_ == IntPtr.Zero)
				id_addFooterView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "addFooterView", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addFooterView_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFooterView", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addFooterView_Landroid_view_View_Ljava_lang_Object_Z;
#pragma warning disable 0169
		static Delegate GetAddFooterView_Landroid_view_View_Ljava_lang_Object_ZHandler ()
		{
			if (cb_addFooterView_Landroid_view_View_Ljava_lang_Object_Z == null)
				cb_addFooterView_Landroid_view_View_Ljava_lang_Object_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AddFooterView_Landroid_view_View_Ljava_lang_Object_Z);
			return cb_addFooterView_Landroid_view_View_Ljava_lang_Object_Z;
		}

		static void n_AddFooterView_Landroid_view_View_Ljava_lang_Object_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddFooterView (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addFooterView_Landroid_view_View_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='addFooterView' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='boolean']]"
		[Register ("addFooterView", "(Landroid/view/View;Ljava/lang/Object;Z)V", "GetAddFooterView_Landroid_view_View_Ljava_lang_Object_ZHandler")]
		public virtual unsafe void AddFooterView (global::Android.Views.View p0, global::Java.Lang.Object p1, bool p2)
		{
			if (id_addFooterView_Landroid_view_View_Ljava_lang_Object_Z == IntPtr.Zero)
				id_addFooterView_Landroid_view_View_Ljava_lang_Object_Z = JNIEnv.GetMethodID (class_ref, "addFooterView", "(Landroid/view/View;Ljava/lang/Object;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addFooterView_Landroid_view_View_Ljava_lang_Object_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFooterView", "(Landroid/view/View;Ljava/lang/Object;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addHeaderView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetAddHeaderView_Landroid_view_View_Handler ()
		{
			if (cb_addHeaderView_Landroid_view_View_ == null)
				cb_addHeaderView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddHeaderView_Landroid_view_View_);
			return cb_addHeaderView_Landroid_view_View_;
		}

		static void n_AddHeaderView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddHeaderView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addHeaderView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='addHeaderView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("addHeaderView", "(Landroid/view/View;)V", "GetAddHeaderView_Landroid_view_View_Handler")]
		public virtual unsafe void AddHeaderView (global::Android.Views.View p0)
		{
			if (id_addHeaderView_Landroid_view_View_ == IntPtr.Zero)
				id_addHeaderView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "addHeaderView", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addHeaderView_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHeaderView", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addHeaderView_Landroid_view_View_Ljava_lang_Object_Z;
#pragma warning disable 0169
		static Delegate GetAddHeaderView_Landroid_view_View_Ljava_lang_Object_ZHandler ()
		{
			if (cb_addHeaderView_Landroid_view_View_Ljava_lang_Object_Z == null)
				cb_addHeaderView_Landroid_view_View_Ljava_lang_Object_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AddHeaderView_Landroid_view_View_Ljava_lang_Object_Z);
			return cb_addHeaderView_Landroid_view_View_Ljava_lang_Object_Z;
		}

		static void n_AddHeaderView_Landroid_view_View_Ljava_lang_Object_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddHeaderView (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addHeaderView_Landroid_view_View_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='addHeaderView' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='boolean']]"
		[Register ("addHeaderView", "(Landroid/view/View;Ljava/lang/Object;Z)V", "GetAddHeaderView_Landroid_view_View_Ljava_lang_Object_ZHandler")]
		public virtual unsafe void AddHeaderView (global::Android.Views.View p0, global::Java.Lang.Object p1, bool p2)
		{
			if (id_addHeaderView_Landroid_view_View_Ljava_lang_Object_Z == IntPtr.Zero)
				id_addHeaderView_Landroid_view_View_Ljava_lang_Object_Z = JNIEnv.GetMethodID (class_ref, "addHeaderView", "(Landroid/view/View;Ljava/lang/Object;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addHeaderView_Landroid_view_View_Ljava_lang_Object_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHeaderView", "(Landroid/view/View;Ljava/lang/Object;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_areHeadersSticky;
#pragma warning disable 0169
		static Delegate GetInvokeAreHeadersStickyHandler ()
		{
			if (cb_areHeadersSticky == null)
				cb_areHeadersSticky = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_InvokeAreHeadersSticky);
			return cb_areHeadersSticky;
		}

		static bool n_InvokeAreHeadersSticky (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InvokeAreHeadersSticky ();
		}
#pragma warning restore 0169

		static IntPtr id_areHeadersSticky;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='areHeadersSticky' and count(parameter)=0]"
		[Register ("areHeadersSticky", "()Z", "GetInvokeAreHeadersStickyHandler")]
		public virtual unsafe bool InvokeAreHeadersSticky ()
		{
			if (id_areHeadersSticky == IntPtr.Zero)
				id_areHeadersSticky = JNIEnv.GetMethodID (class_ref, "areHeadersSticky", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_areHeadersSticky);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "areHeadersSticky", "()Z"));
			} finally {
			}
		}

		static Delegate cb_getCheckedItemIds;
#pragma warning disable 0169
		static Delegate GetGetCheckedItemIdsHandler ()
		{
			if (cb_getCheckedItemIds == null)
				cb_getCheckedItemIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCheckedItemIds);
			return cb_getCheckedItemIds;
		}

		static IntPtr n_GetCheckedItemIds (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCheckedItemIds ());
		}
#pragma warning restore 0169

		static IntPtr id_getCheckedItemIds;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getCheckedItemIds' and count(parameter)=0]"
		[Register ("getCheckedItemIds", "()[J", "GetGetCheckedItemIdsHandler")]
		public virtual unsafe long[] GetCheckedItemIds ()
		{
			if (id_getCheckedItemIds == IntPtr.Zero)
				id_getCheckedItemIds = JNIEnv.GetMethodID (class_ref, "getCheckedItemIds", "()[J");
			try {

				if (GetType () == ThresholdType)
					return (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getCheckedItemIds), JniHandleOwnership.TransferLocalRef, typeof (long));
				else
					return (long[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCheckedItemIds", "()[J")), JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
			}
		}

		static Delegate cb_getHeaderOverlap_I;
#pragma warning disable 0169
		static Delegate GetGetHeaderOverlap_IHandler ()
		{
			if (cb_getHeaderOverlap_I == null)
				cb_getHeaderOverlap_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetHeaderOverlap_I);
			return cb_getHeaderOverlap_I;
		}

		static int n_GetHeaderOverlap_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHeaderOverlap (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderOverlap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getHeaderOverlap' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getHeaderOverlap", "(I)I", "GetGetHeaderOverlap_IHandler")]
		public virtual unsafe int GetHeaderOverlap (int p0)
		{
			if (id_getHeaderOverlap_I == IntPtr.Zero)
				id_getHeaderOverlap_I = JNIEnv.GetMethodID (class_ref, "getHeaderOverlap", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getHeaderOverlap_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaderOverlap", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getItemAtPosition_I;
#pragma warning disable 0169
		static Delegate GetGetItemAtPosition_IHandler ()
		{
			if (cb_getItemAtPosition_I == null)
				cb_getItemAtPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItemAtPosition_I);
			return cb_getItemAtPosition_I;
		}

		static IntPtr n_GetItemAtPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItemAtPosition (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItemAtPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getItemAtPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemAtPosition", "(I)Ljava/lang/Object;", "GetGetItemAtPosition_IHandler")]
		public virtual unsafe global::Java.Lang.Object GetItemAtPosition (int p0)
		{
			if (id_getItemAtPosition_I == IntPtr.Zero)
				id_getItemAtPosition_I = JNIEnv.GetMethodID (class_ref, "getItemAtPosition", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getItemAtPosition_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemAtPosition", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getItemIdAtPosition_I;
#pragma warning disable 0169
		static Delegate GetGetItemIdAtPosition_IHandler ()
		{
			if (cb_getItemIdAtPosition_I == null)
				cb_getItemIdAtPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetItemIdAtPosition_I);
			return cb_getItemIdAtPosition_I;
		}

		static long n_GetItemIdAtPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemIdAtPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getItemIdAtPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getItemIdAtPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemIdAtPosition", "(I)J", "GetGetItemIdAtPosition_IHandler")]
		public virtual unsafe long GetItemIdAtPosition (int p0)
		{
			if (id_getItemIdAtPosition_I == IntPtr.Zero)
				id_getItemIdAtPosition_I = JNIEnv.GetMethodID (class_ref, "getItemIdAtPosition", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getItemIdAtPosition_I, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemIdAtPosition", "(I)J"), __args);
			} finally {
			}
		}

		static Delegate cb_getListChildAt_I;
#pragma warning disable 0169
		static Delegate GetGetListChildAt_IHandler ()
		{
			if (cb_getListChildAt_I == null)
				cb_getListChildAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetListChildAt_I);
			return cb_getListChildAt_I;
		}

		static IntPtr n_GetListChildAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetListChildAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getListChildAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getListChildAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getListChildAt", "(I)Landroid/view/View;", "GetGetListChildAt_IHandler")]
		public virtual unsafe global::Android.Views.View GetListChildAt (int p0)
		{
			if (id_getListChildAt_I == IntPtr.Zero)
				id_getListChildAt_I = JNIEnv.GetMethodID (class_ref, "getListChildAt", "(I)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getListChildAt_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListChildAt", "(I)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPositionForView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetPositionForView_Landroid_view_View_Handler ()
		{
			if (cb_getPositionForView_Landroid_view_View_ == null)
				cb_getPositionForView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetPositionForView_Landroid_view_View_);
			return cb_getPositionForView_Landroid_view_View_;
		}

		static int n_GetPositionForView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetPositionForView (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPositionForView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='getPositionForView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getPositionForView", "(Landroid/view/View;)I", "GetGetPositionForView_Landroid_view_View_Handler")]
		public virtual unsafe int GetPositionForView (global::Android.Views.View p0)
		{
			if (id_getPositionForView_Landroid_view_View_ == IntPtr.Zero)
				id_getPositionForView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getPositionForView", "(Landroid/view/View;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_getPositionForView_Landroid_view_View_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPositionForView", "(Landroid/view/View;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_invalidateViews;
#pragma warning disable 0169
		static Delegate GetInvalidateViewsHandler ()
		{
			if (cb_invalidateViews == null)
				cb_invalidateViews = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InvalidateViews);
			return cb_invalidateViews;
		}

		static void n_InvalidateViews (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateViews ();
		}
#pragma warning restore 0169

		static IntPtr id_invalidateViews;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='invalidateViews' and count(parameter)=0]"
		[Register ("invalidateViews", "()V", "GetInvalidateViewsHandler")]
		public virtual unsafe void InvalidateViews ()
		{
			if (id_invalidateViews == IntPtr.Zero)
				id_invalidateViews = JNIEnv.GetMethodID (class_ref, "invalidateViews", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_invalidateViews);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invalidateViews", "()V"));
			} finally {
			}
		}

		static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;
#pragma warning disable 0169
		static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler ()
		{
			if (cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
				cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRestoreInstanceState_Landroid_os_Parcelable_);
			return cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		static void n_OnRestoreInstanceState_Landroid_os_Parcelable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IParcelable p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRestoreInstanceState_Landroid_os_Parcelable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
		[Register ("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler")]
		public virtual unsafe void OnRestoreInstanceState (global::Android.OS.IParcelable p0)
		{
			if (id_onRestoreInstanceState_Landroid_os_Parcelable_ == IntPtr.Zero)
				id_onRestoreInstanceState_Landroid_os_Parcelable_ = JNIEnv.GetMethodID (class_ref, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRestoreInstanceState_Landroid_os_Parcelable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSaveInstanceState;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceStateHandler ()
		{
			if (cb_onSaveInstanceState == null)
				cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState);
			return cb_onSaveInstanceState;
		}

		static IntPtr n_OnSaveInstanceState (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSaveInstanceState ());
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='onSaveInstanceState' and count(parameter)=0]"
		[Register ("onSaveInstanceState", "()Landroid/os/Parcelable;", "GetOnSaveInstanceStateHandler")]
		public virtual unsafe global::Android.OS.IParcelable OnSaveInstanceState ()
		{
			if (id_onSaveInstanceState == IntPtr.Zero)
				id_onSaveInstanceState = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallObjectMethod  (Handle, id_onSaveInstanceState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSaveInstanceState", "()Landroid/os/Parcelable;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_recomputePadding;
#pragma warning disable 0169
		static Delegate GetRecomputePaddingHandler ()
		{
			if (cb_recomputePadding == null)
				cb_recomputePadding = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecomputePadding);
			return cb_recomputePadding;
		}

		static void n_RecomputePadding (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecomputePadding ();
		}
#pragma warning restore 0169

		static IntPtr id_recomputePadding;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='recomputePadding' and count(parameter)=0]"
		[Register ("recomputePadding", "()V", "GetRecomputePaddingHandler")]
		protected virtual unsafe void RecomputePadding ()
		{
			if (id_recomputePadding == IntPtr.Zero)
				id_recomputePadding = JNIEnv.GetMethodID (class_ref, "recomputePadding", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_recomputePadding);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recomputePadding", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeFooterView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetRemoveFooterView_Landroid_view_View_Handler ()
		{
			if (cb_removeFooterView_Landroid_view_View_ == null)
				cb_removeFooterView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveFooterView_Landroid_view_View_);
			return cb_removeFooterView_Landroid_view_View_;
		}

		static void n_RemoveFooterView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveFooterView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeFooterView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='removeFooterView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("removeFooterView", "(Landroid/view/View;)V", "GetRemoveFooterView_Landroid_view_View_Handler")]
		public virtual unsafe void RemoveFooterView (global::Android.Views.View p0)
		{
			if (id_removeFooterView_Landroid_view_View_ == IntPtr.Zero)
				id_removeFooterView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "removeFooterView", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeFooterView_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeFooterView", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeHeaderView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetRemoveHeaderView_Landroid_view_View_Handler ()
		{
			if (cb_removeHeaderView_Landroid_view_View_ == null)
				cb_removeHeaderView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveHeaderView_Landroid_view_View_);
			return cb_removeHeaderView_Landroid_view_View_;
		}

		static void n_RemoveHeaderView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveHeaderView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeHeaderView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='removeHeaderView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("removeHeaderView", "(Landroid/view/View;)V", "GetRemoveHeaderView_Landroid_view_View_Handler")]
		public virtual unsafe void RemoveHeaderView (global::Android.Views.View p0)
		{
			if (id_removeHeaderView_Landroid_view_View_ == IntPtr.Zero)
				id_removeHeaderView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "removeHeaderView", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeHeaderView_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeHeaderView", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setBlockLayoutChildren_Z;
#pragma warning disable 0169
		static Delegate GetSetBlockLayoutChildren_ZHandler ()
		{
			if (cb_setBlockLayoutChildren_Z == null)
				cb_setBlockLayoutChildren_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBlockLayoutChildren_Z);
			return cb_setBlockLayoutChildren_Z;
		}

		static void n_SetBlockLayoutChildren_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBlockLayoutChildren (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBlockLayoutChildren_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setBlockLayoutChildren' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setBlockLayoutChildren", "(Z)V", "GetSetBlockLayoutChildren_ZHandler")]
		public virtual unsafe void SetBlockLayoutChildren (bool p0)
		{
			if (id_setBlockLayoutChildren_Z == IntPtr.Zero)
				id_setBlockLayoutChildren_Z = JNIEnv.GetMethodID (class_ref, "setBlockLayoutChildren", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBlockLayoutChildren_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlockLayoutChildren", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setChoiceMode_I;
#pragma warning disable 0169
		static Delegate GetSetChoiceMode_IHandler ()
		{
			if (cb_setChoiceMode_I == null)
				cb_setChoiceMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetChoiceMode_I);
			return cb_setChoiceMode_I;
		}

		static void n_SetChoiceMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChoiceMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setChoiceMode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setChoiceMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setChoiceMode", "(I)V", "GetSetChoiceMode_IHandler")]
		public virtual unsafe void SetChoiceMode (int p0)
		{
			if (id_setChoiceMode_I == IntPtr.Zero)
				id_setChoiceMode_I = JNIEnv.GetMethodID (class_ref, "setChoiceMode", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setChoiceMode_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChoiceMode", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setFastScrollEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetFastScrollEnabled_ZHandler ()
		{
			if (cb_setFastScrollEnabled_Z == null)
				cb_setFastScrollEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFastScrollEnabled_Z);
			return cb_setFastScrollEnabled_Z;
		}

		static void n_SetFastScrollEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFastScrollEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFastScrollEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setFastScrollEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFastScrollEnabled", "(Z)V", "GetSetFastScrollEnabled_ZHandler")]
		public virtual unsafe void SetFastScrollEnabled (bool p0)
		{
			if (id_setFastScrollEnabled_Z == IntPtr.Zero)
				id_setFastScrollEnabled_Z = JNIEnv.GetMethodID (class_ref, "setFastScrollEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFastScrollEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFastScrollEnabled", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setItemChecked_IZ;
#pragma warning disable 0169
		static Delegate GetSetItemChecked_IZHandler ()
		{
			if (cb_setItemChecked_IZ == null)
				cb_setItemChecked_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetItemChecked_IZ);
			return cb_setItemChecked_IZ;
		}

		static void n_SetItemChecked_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetItemChecked (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setItemChecked_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setItemChecked' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setItemChecked", "(IZ)V", "GetSetItemChecked_IZHandler")]
		public virtual unsafe void SetItemChecked (int p0, bool p1)
		{
			if (id_setItemChecked_IZ == IntPtr.Zero)
				id_setItemChecked_IZ = JNIEnv.GetMethodID (class_ref, "setItemChecked", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setItemChecked_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemChecked", "(IZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMultiChoiceModeListener_Landroid_widget_AbsListView_MultiChoiceModeListener_;
#pragma warning disable 0169
		static Delegate GetSetMultiChoiceModeListener_Landroid_widget_AbsListView_MultiChoiceModeListener_Handler ()
		{
			if (cb_setMultiChoiceModeListener_Landroid_widget_AbsListView_MultiChoiceModeListener_ == null)
				cb_setMultiChoiceModeListener_Landroid_widget_AbsListView_MultiChoiceModeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMultiChoiceModeListener_Landroid_widget_AbsListView_MultiChoiceModeListener_);
			return cb_setMultiChoiceModeListener_Landroid_widget_AbsListView_MultiChoiceModeListener_;
		}

		static void n_SetMultiChoiceModeListener_Landroid_widget_AbsListView_MultiChoiceModeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AbsListView.IMultiChoiceModeListener p0 = (global::Android.Widget.AbsListView.IMultiChoiceModeListener)global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView.IMultiChoiceModeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMultiChoiceModeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMultiChoiceModeListener_Landroid_widget_AbsListView_MultiChoiceModeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setMultiChoiceModeListener' and count(parameter)=1 and parameter[1][@type='android.widget.AbsListView.MultiChoiceModeListener']]"
		[Register ("setMultiChoiceModeListener", "(Landroid/widget/AbsListView$MultiChoiceModeListener;)V", "GetSetMultiChoiceModeListener_Landroid_widget_AbsListView_MultiChoiceModeListener_Handler")]
		public virtual unsafe void SetMultiChoiceModeListener (global::Android.Widget.AbsListView.IMultiChoiceModeListener p0)
		{
			if (id_setMultiChoiceModeListener_Landroid_widget_AbsListView_MultiChoiceModeListener_ == IntPtr.Zero)
				id_setMultiChoiceModeListener_Landroid_widget_AbsListView_MultiChoiceModeListener_ = JNIEnv.GetMethodID (class_ref, "setMultiChoiceModeListener", "(Landroid/widget/AbsListView$MultiChoiceModeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMultiChoiceModeListener_Landroid_widget_AbsListView_MultiChoiceModeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMultiChoiceModeListener", "(Landroid/widget/AbsListView$MultiChoiceModeListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnHeaderClickListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnHeaderClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnHeaderClickListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnHeaderClickListener_Handler ()
		{
			if (cb_setOnHeaderClickListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnHeaderClickListener_ == null)
				cb_setOnHeaderClickListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnHeaderClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnHeaderClickListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnHeaderClickListener_);
			return cb_setOnHeaderClickListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnHeaderClickListener_;
		}

		static void n_SetOnHeaderClickListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnHeaderClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnHeaderClickListener p0 = (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnHeaderClickListener)global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnHeaderClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnHeaderClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnHeaderClickListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnHeaderClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setOnHeaderClickListener' and count(parameter)=1 and parameter[1][@type='se.emilsjolander.stickylistheaders.StickyListHeadersListView.OnHeaderClickListener']]"
		[Register ("setOnHeaderClickListener", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersListView$OnHeaderClickListener;)V", "GetSetOnHeaderClickListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnHeaderClickListener_Handler")]
		public virtual unsafe void SetOnHeaderClickListener (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnHeaderClickListener p0)
		{
			if (id_setOnHeaderClickListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnHeaderClickListener_ == IntPtr.Zero)
				id_setOnHeaderClickListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnHeaderClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnHeaderClickListener", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersListView$OnHeaderClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnHeaderClickListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnHeaderClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnHeaderClickListener", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersListView$OnHeaderClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_Handler ()
		{
			if (cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ == null)
				cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_);
			return cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_;
		}

		static void n_SetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AdapterView.IOnItemClickListener p0 = (global::Android.Widget.AdapterView.IOnItemClickListener)global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView.IOnItemClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnItemClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setOnItemClickListener' and count(parameter)=1 and parameter[1][@type='android.widget.AdapterView.OnItemClickListener']]"
		[Register ("setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", "GetSetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_Handler")]
		public virtual unsafe void SetOnItemClickListener (global::Android.Widget.AdapterView.IOnItemClickListener p0)
		{
			if (id_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ == IntPtr.Zero)
				id_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnItemLongClickListener_Landroid_widget_AdapterView_OnItemLongClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnItemLongClickListener_Landroid_widget_AdapterView_OnItemLongClickListener_Handler ()
		{
			if (cb_setOnItemLongClickListener_Landroid_widget_AdapterView_OnItemLongClickListener_ == null)
				cb_setOnItemLongClickListener_Landroid_widget_AdapterView_OnItemLongClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnItemLongClickListener_Landroid_widget_AdapterView_OnItemLongClickListener_);
			return cb_setOnItemLongClickListener_Landroid_widget_AdapterView_OnItemLongClickListener_;
		}

		static void n_SetOnItemLongClickListener_Landroid_widget_AdapterView_OnItemLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AdapterView.IOnItemLongClickListener p0 = (global::Android.Widget.AdapterView.IOnItemLongClickListener)global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView.IOnItemLongClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnItemLongClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnItemLongClickListener_Landroid_widget_AdapterView_OnItemLongClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setOnItemLongClickListener' and count(parameter)=1 and parameter[1][@type='android.widget.AdapterView.OnItemLongClickListener']]"
		[Register ("setOnItemLongClickListener", "(Landroid/widget/AdapterView$OnItemLongClickListener;)V", "GetSetOnItemLongClickListener_Landroid_widget_AdapterView_OnItemLongClickListener_Handler")]
		public virtual unsafe void SetOnItemLongClickListener (global::Android.Widget.AdapterView.IOnItemLongClickListener p0)
		{
			if (id_setOnItemLongClickListener_Landroid_widget_AdapterView_OnItemLongClickListener_ == IntPtr.Zero)
				id_setOnItemLongClickListener_Landroid_widget_AdapterView_OnItemLongClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnItemLongClickListener", "(Landroid/widget/AdapterView$OnItemLongClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnItemLongClickListener_Landroid_widget_AdapterView_OnItemLongClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnItemLongClickListener", "(Landroid/widget/AdapterView$OnItemLongClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_;
#pragma warning disable 0169
		static Delegate GetSetOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_Handler ()
		{
			if (cb_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_ == null)
				cb_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_);
			return cb_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_;
		}

		static void n_SetOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AbsListView.IOnScrollListener p0 = (global::Android.Widget.AbsListView.IOnScrollListener)global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView.IOnScrollListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnScrollListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setOnScrollListener' and count(parameter)=1 and parameter[1][@type='android.widget.AbsListView.OnScrollListener']]"
		[Register ("setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V", "GetSetOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_Handler")]
		public virtual unsafe void SetOnScrollListener (global::Android.Widget.AbsListView.IOnScrollListener p0)
		{
			if (id_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_ == IntPtr.Zero)
				id_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_ = JNIEnv.GetMethodID (class_ref, "setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnStickyHeaderChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderChangedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnStickyHeaderChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderChangedListener_Handler ()
		{
			if (cb_setOnStickyHeaderChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderChangedListener_ == null)
				cb_setOnStickyHeaderChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnStickyHeaderChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderChangedListener_);
			return cb_setOnStickyHeaderChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderChangedListener_;
		}

		static void n_SetOnStickyHeaderChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderChangedListener p0 = (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderChangedListener)global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnStickyHeaderChangedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnStickyHeaderChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setOnStickyHeaderChangedListener' and count(parameter)=1 and parameter[1][@type='se.emilsjolander.stickylistheaders.StickyListHeadersListView.OnStickyHeaderChangedListener']]"
		[Register ("setOnStickyHeaderChangedListener", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersListView$OnStickyHeaderChangedListener;)V", "GetSetOnStickyHeaderChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderChangedListener_Handler")]
		public virtual unsafe void SetOnStickyHeaderChangedListener (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderChangedListener p0)
		{
			if (id_setOnStickyHeaderChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderChangedListener_ == IntPtr.Zero)
				id_setOnStickyHeaderChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderChangedListener_ = JNIEnv.GetMethodID (class_ref, "setOnStickyHeaderChangedListener", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersListView$OnStickyHeaderChangedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnStickyHeaderChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderChangedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnStickyHeaderChangedListener", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersListView$OnStickyHeaderChangedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnStickyHeaderOffsetChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderOffsetChangedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnStickyHeaderOffsetChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderOffsetChangedListener_Handler ()
		{
			if (cb_setOnStickyHeaderOffsetChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderOffsetChangedListener_ == null)
				cb_setOnStickyHeaderOffsetChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderOffsetChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnStickyHeaderOffsetChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderOffsetChangedListener_);
			return cb_setOnStickyHeaderOffsetChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderOffsetChangedListener_;
		}

		static void n_SetOnStickyHeaderOffsetChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderOffsetChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderOffsetChangedListener p0 = (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderOffsetChangedListener)global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderOffsetChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnStickyHeaderOffsetChangedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnStickyHeaderOffsetChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderOffsetChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setOnStickyHeaderOffsetChangedListener' and count(parameter)=1 and parameter[1][@type='se.emilsjolander.stickylistheaders.StickyListHeadersListView.OnStickyHeaderOffsetChangedListener']]"
		[Register ("setOnStickyHeaderOffsetChangedListener", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersListView$OnStickyHeaderOffsetChangedListener;)V", "GetSetOnStickyHeaderOffsetChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderOffsetChangedListener_Handler")]
		public virtual unsafe void SetOnStickyHeaderOffsetChangedListener (global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderOffsetChangedListener p0)
		{
			if (id_setOnStickyHeaderOffsetChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderOffsetChangedListener_ == IntPtr.Zero)
				id_setOnStickyHeaderOffsetChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderOffsetChangedListener_ = JNIEnv.GetMethodID (class_ref, "setOnStickyHeaderOffsetChangedListener", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersListView$OnStickyHeaderOffsetChangedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnStickyHeaderOffsetChangedListener_Lse_emilsjolander_stickylistheaders_StickyListHeadersListView_OnStickyHeaderOffsetChangedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnStickyHeaderOffsetChangedListener", "(Lse/emilsjolander/stickylistheaders/StickyListHeadersListView$OnStickyHeaderOffsetChangedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelection_I;
#pragma warning disable 0169
		static Delegate GetSetSelection_IHandler ()
		{
			if (cb_setSelection_I == null)
				cb_setSelection_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelection_I);
			return cb_setSelection_I;
		}

		static void n_SetSelection_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelection_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setSelection' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelection", "(I)V", "GetSetSelection_IHandler")]
		public virtual unsafe void SetSelection (int p0)
		{
			if (id_setSelection_I == IntPtr.Zero)
				id_setSelection_I = JNIEnv.GetMethodID (class_ref, "setSelection", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSelection_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelection", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelectionAfterHeaderView;
#pragma warning disable 0169
		static Delegate GetSetSelectionAfterHeaderViewHandler ()
		{
			if (cb_setSelectionAfterHeaderView == null)
				cb_setSelectionAfterHeaderView = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetSelectionAfterHeaderView);
			return cb_setSelectionAfterHeaderView;
		}

		static void n_SetSelectionAfterHeaderView (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectionAfterHeaderView ();
		}
#pragma warning restore 0169

		static IntPtr id_setSelectionAfterHeaderView;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setSelectionAfterHeaderView' and count(parameter)=0]"
		[Register ("setSelectionAfterHeaderView", "()V", "GetSetSelectionAfterHeaderViewHandler")]
		public virtual unsafe void SetSelectionAfterHeaderView ()
		{
			if (id_setSelectionAfterHeaderView == IntPtr.Zero)
				id_setSelectionAfterHeaderView = JNIEnv.GetMethodID (class_ref, "setSelectionAfterHeaderView", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSelectionAfterHeaderView);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectionAfterHeaderView", "()V"));
			} finally {
			}
		}

		static Delegate cb_setSelectionFromTop_II;
#pragma warning disable 0169
		static Delegate GetSetSelectionFromTop_IIHandler ()
		{
			if (cb_setSelectionFromTop_II == null)
				cb_setSelectionFromTop_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetSelectionFromTop_II);
			return cb_setSelectionFromTop_II;
		}

		static void n_SetSelectionFromTop_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectionFromTop (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectionFromTop_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setSelectionFromTop' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setSelectionFromTop", "(II)V", "GetSetSelectionFromTop_IIHandler")]
		public virtual unsafe void SetSelectionFromTop (int p0, int p1)
		{
			if (id_setSelectionFromTop_II == IntPtr.Zero)
				id_setSelectionFromTop_II = JNIEnv.GetMethodID (class_ref, "setSelectionFromTop", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSelectionFromTop_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectionFromTop", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelector_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetSelector_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setSelector_Landroid_graphics_drawable_Drawable_ == null)
				cb_setSelector_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelector_Landroid_graphics_drawable_Drawable_);
			return cb_setSelector_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetSelector_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSelector (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelector_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setSelector' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setSelector", "(Landroid/graphics/drawable/Drawable;)V", "GetSetSelector_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetSelector (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setSelector_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setSelector_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setSelector", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSelector_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelector", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelector_I;
#pragma warning disable 0169
		static Delegate GetSetSelector_IHandler ()
		{
			if (cb_setSelector_I == null)
				cb_setSelector_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelector_I);
			return cb_setSelector_I;
		}

		static void n_SetSelector_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelector (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelector_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setSelector' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelector", "(I)V", "GetSetSelector_IHandler")]
		public virtual unsafe void SetSelector (int p0)
		{
			if (id_setSelector_I == IntPtr.Zero)
				id_setSelector_I = JNIEnv.GetMethodID (class_ref, "setSelector", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSelector_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelector", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTranscriptMode_I;
#pragma warning disable 0169
		static Delegate GetSetTranscriptMode_IHandler ()
		{
			if (cb_setTranscriptMode_I == null)
				cb_setTranscriptMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTranscriptMode_I);
			return cb_setTranscriptMode_I;
		}

		static void n_SetTranscriptMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTranscriptMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTranscriptMode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='setTranscriptMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTranscriptMode", "(I)V", "GetSetTranscriptMode_IHandler")]
		public virtual unsafe void SetTranscriptMode (int p0)
		{
			if (id_setTranscriptMode_I == IntPtr.Zero)
				id_setTranscriptMode_I = JNIEnv.GetMethodID (class_ref, "setTranscriptMode", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTranscriptMode_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTranscriptMode", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_smoothScrollBy_II;
#pragma warning disable 0169
		static Delegate GetSmoothScrollBy_IIHandler ()
		{
			if (cb_smoothScrollBy_II == null)
				cb_smoothScrollBy_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SmoothScrollBy_II);
			return cb_smoothScrollBy_II;
		}

		static void n_SmoothScrollBy_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmoothScrollBy (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_smoothScrollBy_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='smoothScrollBy' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("smoothScrollBy", "(II)V", "GetSmoothScrollBy_IIHandler")]
		public virtual unsafe void SmoothScrollBy (int p0, int p1)
		{
			if (id_smoothScrollBy_II == IntPtr.Zero)
				id_smoothScrollBy_II = JNIEnv.GetMethodID (class_ref, "smoothScrollBy", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_smoothScrollBy_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "smoothScrollBy", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_smoothScrollByOffset_I;
#pragma warning disable 0169
		static Delegate GetSmoothScrollByOffset_IHandler ()
		{
			if (cb_smoothScrollByOffset_I == null)
				cb_smoothScrollByOffset_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SmoothScrollByOffset_I);
			return cb_smoothScrollByOffset_I;
		}

		static void n_SmoothScrollByOffset_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmoothScrollByOffset (p0);
		}
#pragma warning restore 0169

		static IntPtr id_smoothScrollByOffset_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='smoothScrollByOffset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("smoothScrollByOffset", "(I)V", "GetSmoothScrollByOffset_IHandler")]
		public virtual unsafe void SmoothScrollByOffset (int p0)
		{
			if (id_smoothScrollByOffset_I == IntPtr.Zero)
				id_smoothScrollByOffset_I = JNIEnv.GetMethodID (class_ref, "smoothScrollByOffset", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_smoothScrollByOffset_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "smoothScrollByOffset", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_smoothScrollToPosition_I;
#pragma warning disable 0169
		static Delegate GetSmoothScrollToPosition_IHandler ()
		{
			if (cb_smoothScrollToPosition_I == null)
				cb_smoothScrollToPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SmoothScrollToPosition_I);
			return cb_smoothScrollToPosition_I;
		}

		static void n_SmoothScrollToPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmoothScrollToPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_smoothScrollToPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='smoothScrollToPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("smoothScrollToPosition", "(I)V", "GetSmoothScrollToPosition_IHandler")]
		public virtual unsafe void SmoothScrollToPosition (int p0)
		{
			if (id_smoothScrollToPosition_I == IntPtr.Zero)
				id_smoothScrollToPosition_I = JNIEnv.GetMethodID (class_ref, "smoothScrollToPosition", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_smoothScrollToPosition_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "smoothScrollToPosition", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_smoothScrollToPosition_II;
#pragma warning disable 0169
		static Delegate GetSmoothScrollToPosition_IIHandler ()
		{
			if (cb_smoothScrollToPosition_II == null)
				cb_smoothScrollToPosition_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SmoothScrollToPosition_II);
			return cb_smoothScrollToPosition_II;
		}

		static void n_SmoothScrollToPosition_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmoothScrollToPosition (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_smoothScrollToPosition_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='smoothScrollToPosition' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("smoothScrollToPosition", "(II)V", "GetSmoothScrollToPosition_IIHandler")]
		public virtual unsafe void SmoothScrollToPosition (int p0, int p1)
		{
			if (id_smoothScrollToPosition_II == IntPtr.Zero)
				id_smoothScrollToPosition_II = JNIEnv.GetMethodID (class_ref, "smoothScrollToPosition", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_smoothScrollToPosition_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "smoothScrollToPosition", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_smoothScrollToPositionFromTop_II;
#pragma warning disable 0169
		static Delegate GetSmoothScrollToPositionFromTop_IIHandler ()
		{
			if (cb_smoothScrollToPositionFromTop_II == null)
				cb_smoothScrollToPositionFromTop_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SmoothScrollToPositionFromTop_II);
			return cb_smoothScrollToPositionFromTop_II;
		}

		static void n_SmoothScrollToPositionFromTop_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmoothScrollToPositionFromTop (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_smoothScrollToPositionFromTop_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='smoothScrollToPositionFromTop' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("smoothScrollToPositionFromTop", "(II)V", "GetSmoothScrollToPositionFromTop_IIHandler")]
		public virtual unsafe void SmoothScrollToPositionFromTop (int p0, int p1)
		{
			if (id_smoothScrollToPositionFromTop_II == IntPtr.Zero)
				id_smoothScrollToPositionFromTop_II = JNIEnv.GetMethodID (class_ref, "smoothScrollToPositionFromTop", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_smoothScrollToPositionFromTop_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "smoothScrollToPositionFromTop", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_smoothScrollToPositionFromTop_III;
#pragma warning disable 0169
		static Delegate GetSmoothScrollToPositionFromTop_IIIHandler ()
		{
			if (cb_smoothScrollToPositionFromTop_III == null)
				cb_smoothScrollToPositionFromTop_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_SmoothScrollToPositionFromTop_III);
			return cb_smoothScrollToPositionFromTop_III;
		}

		static void n_SmoothScrollToPositionFromTop_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmoothScrollToPositionFromTop (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_smoothScrollToPositionFromTop_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='StickyListHeadersListView']/method[@name='smoothScrollToPositionFromTop' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("smoothScrollToPositionFromTop", "(III)V", "GetSmoothScrollToPositionFromTop_IIIHandler")]
		public virtual unsafe void SmoothScrollToPositionFromTop (int p0, int p1, int p2)
		{
			if (id_smoothScrollToPositionFromTop_III == IntPtr.Zero)
				id_smoothScrollToPositionFromTop_III = JNIEnv.GetMethodID (class_ref, "smoothScrollToPositionFromTop", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_smoothScrollToPositionFromTop_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "smoothScrollToPositionFromTop", "(III)V"), __args);
			} finally {
			}
		}

#region "Event implementation for SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnHeaderClickListener"
		public event EventHandler<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.HeaderClickEventArgs> HeaderClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnHeaderClickListener, global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnHeaderClickListenerImplementor>(
						ref weak_implementor_SetOnHeaderClickListener,
						__CreateIOnHeaderClickListenerImplementor,
						SetOnHeaderClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnHeaderClickListener, global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnHeaderClickListenerImplementor>(
						ref weak_implementor_SetOnHeaderClickListener,
						global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnHeaderClickListenerImplementor.__IsEmpty,
						__v => SetOnHeaderClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnHeaderClickListener;

		global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnHeaderClickListenerImplementor __CreateIOnHeaderClickListenerImplementor ()
		{
			return new global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnHeaderClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderChangedListener"
		public event EventHandler<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.StickyHeaderChangedEventArgs> StickyHeaderChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderChangedListener, global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderChangedListenerImplementor>(
						ref weak_implementor_SetOnStickyHeaderChangedListener,
						__CreateIOnStickyHeaderChangedListenerImplementor,
						SetOnStickyHeaderChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderChangedListener, global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderChangedListenerImplementor>(
						ref weak_implementor_SetOnStickyHeaderChangedListener,
						global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderChangedListenerImplementor.__IsEmpty,
						__v => SetOnStickyHeaderChangedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnStickyHeaderChangedListener;

		global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderChangedListenerImplementor __CreateIOnStickyHeaderChangedListenerImplementor ()
		{
			return new global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderChangedListenerImplementor (this);
		}
#endregion
#region "Event implementation for SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderOffsetChangedListener"
		public event EventHandler<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.StickyHeaderOffsetChangedEventArgs> StickyHeaderOffsetChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderOffsetChangedListener, global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderOffsetChangedListenerImplementor>(
						ref weak_implementor_SetOnStickyHeaderOffsetChangedListener,
						__CreateIOnStickyHeaderOffsetChangedListenerImplementor,
						SetOnStickyHeaderOffsetChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderOffsetChangedListener, global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderOffsetChangedListenerImplementor>(
						ref weak_implementor_SetOnStickyHeaderOffsetChangedListener,
						global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderOffsetChangedListenerImplementor.__IsEmpty,
						__v => SetOnStickyHeaderOffsetChangedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnStickyHeaderOffsetChangedListener;

		global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderOffsetChangedListenerImplementor __CreateIOnStickyHeaderOffsetChangedListenerImplementor ()
		{
			return new global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView.IOnStickyHeaderOffsetChangedListenerImplementor (this);
		}
#endregion
	}
}
