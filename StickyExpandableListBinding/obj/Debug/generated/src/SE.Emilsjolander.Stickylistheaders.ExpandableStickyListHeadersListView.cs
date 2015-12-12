using System;
using System.Collections.Generic;
using Android.Runtime;

namespace SE.Emilsjolander.Stickylistheaders {

	// Metadata.xml XPath class reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='ExpandableStickyListHeadersListView']"
	[global::Android.Runtime.Register ("se/emilsjolander/stickylistheaders/ExpandableStickyListHeadersListView", DoNotGenerateAcw=true)]
	public partial class ExpandableStickyListHeadersListView : global::SE.Emilsjolander.Stickylistheaders.StickyListHeadersListView {


		// Metadata.xml XPath field reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='ExpandableStickyListHeadersListView']/field[@name='ANIMATION_COLLAPSE']"
		[Register ("ANIMATION_COLLAPSE")]
		public const int AnimationCollapse = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='ExpandableStickyListHeadersListView']/field[@name='ANIMATION_EXPAND']"
		[Register ("ANIMATION_EXPAND")]
		public const int AnimationExpand = (int) 0;
		// Metadata.xml XPath interface reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/interface[@name='ExpandableStickyListHeadersListView.IAnimationExecutor']"
		[Register ("se/emilsjolander/stickylistheaders/ExpandableStickyListHeadersListView$IAnimationExecutor", "", "SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView/IAnimationExecutorInvoker")]
		public partial interface IAnimationExecutor : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/interface[@name='ExpandableStickyListHeadersListView.IAnimationExecutor']/method[@name='executeAnim' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
			[Register ("executeAnim", "(Landroid/view/View;I)V", "GetExecuteAnim_Landroid_view_View_IHandler:SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView/IAnimationExecutorInvoker, StickyExpandableListBinding")]
			void ExecuteAnim (global::Android.Views.View p0, int p1);

		}

		[global::Android.Runtime.Register ("se/emilsjolander/stickylistheaders/ExpandableStickyListHeadersListView$IAnimationExecutor", DoNotGenerateAcw=true)]
		internal class IAnimationExecutorInvoker : global::Java.Lang.Object, IAnimationExecutor {

			static IntPtr java_class_ref = JNIEnv.FindClass ("se/emilsjolander/stickylistheaders/ExpandableStickyListHeadersListView$IAnimationExecutor");
			IntPtr class_ref;

			public static IAnimationExecutor GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAnimationExecutor> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "se.emilsjolander.stickylistheaders.ExpandableStickyListHeadersListView.IAnimationExecutor"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAnimationExecutorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAnimationExecutorInvoker); }
			}

			static Delegate cb_executeAnim_Landroid_view_View_I;
#pragma warning disable 0169
			static Delegate GetExecuteAnim_Landroid_view_View_IHandler ()
			{
				if (cb_executeAnim_Landroid_view_View_I == null)
					cb_executeAnim_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_ExecuteAnim_Landroid_view_View_I);
				return cb_executeAnim_Landroid_view_View_I;
			}

			static void n_ExecuteAnim_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView.IAnimationExecutor __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView.IAnimationExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ExecuteAnim (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_executeAnim_Landroid_view_View_I;
			public unsafe void ExecuteAnim (global::Android.Views.View p0, int p1)
			{
				if (id_executeAnim_Landroid_view_View_I == IntPtr.Zero)
					id_executeAnim_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "executeAnim", "(Landroid/view/View;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_executeAnim_Landroid_view_View_I, __args);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("se/emilsjolander/stickylistheaders/ExpandableStickyListHeadersListView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExpandableStickyListHeadersListView); }
		}

		protected ExpandableStickyListHeadersListView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='ExpandableStickyListHeadersListView']/constructor[@name='ExpandableStickyListHeadersListView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ExpandableStickyListHeadersListView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (ExpandableStickyListHeadersListView)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='ExpandableStickyListHeadersListView']/constructor[@name='ExpandableStickyListHeadersListView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ExpandableStickyListHeadersListView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ExpandableStickyListHeadersListView)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='ExpandableStickyListHeadersListView']/constructor[@name='ExpandableStickyListHeadersListView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ExpandableStickyListHeadersListView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ExpandableStickyListHeadersListView)) {
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

		static Delegate cb_collapse_J;
#pragma warning disable 0169
		static Delegate GetCollapse_JHandler ()
		{
			if (cb_collapse_J == null)
				cb_collapse_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Collapse_J);
			return cb_collapse_J;
		}

		static void n_Collapse_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Collapse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_collapse_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='ExpandableStickyListHeadersListView']/method[@name='collapse' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("collapse", "(J)V", "GetCollapse_JHandler")]
		public virtual unsafe void Collapse (long p0)
		{
			if (id_collapse_J == IntPtr.Zero)
				id_collapse_J = JNIEnv.GetMethodID (class_ref, "collapse", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_collapse_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "collapse", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_expand_J;
#pragma warning disable 0169
		static Delegate GetExpand_JHandler ()
		{
			if (cb_expand_J == null)
				cb_expand_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Expand_J);
			return cb_expand_J;
		}

		static void n_Expand_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Expand (p0);
		}
#pragma warning restore 0169

		static IntPtr id_expand_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='ExpandableStickyListHeadersListView']/method[@name='expand' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("expand", "(J)V", "GetExpand_JHandler")]
		public virtual unsafe void Expand (long p0)
		{
			if (id_expand_J == IntPtr.Zero)
				id_expand_J = JNIEnv.GetMethodID (class_ref, "expand", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_expand_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "expand", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_findItemIdByView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetFindItemIdByView_Landroid_view_View_Handler ()
		{
			if (cb_findItemIdByView_Landroid_view_View_ == null)
				cb_findItemIdByView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_FindItemIdByView_Landroid_view_View_);
			return cb_findItemIdByView_Landroid_view_View_;
		}

		static long n_FindItemIdByView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.FindItemIdByView (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findItemIdByView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='ExpandableStickyListHeadersListView']/method[@name='findItemIdByView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("findItemIdByView", "(Landroid/view/View;)J", "GetFindItemIdByView_Landroid_view_View_Handler")]
		public virtual unsafe long FindItemIdByView (global::Android.Views.View p0)
		{
			if (id_findItemIdByView_Landroid_view_View_ == IntPtr.Zero)
				id_findItemIdByView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "findItemIdByView", "(Landroid/view/View;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				long __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod  (Handle, id_findItemIdByView_Landroid_view_View_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findItemIdByView", "(Landroid/view/View;)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_findViewByItemId_J;
#pragma warning disable 0169
		static Delegate GetFindViewByItemId_JHandler ()
		{
			if (cb_findViewByItemId_J == null)
				cb_findViewByItemId_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_FindViewByItemId_J);
			return cb_findViewByItemId_J;
		}

		static IntPtr n_FindViewByItemId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindViewByItemId (p0));
		}
#pragma warning restore 0169

		static IntPtr id_findViewByItemId_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='ExpandableStickyListHeadersListView']/method[@name='findViewByItemId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("findViewByItemId", "(J)Landroid/view/View;", "GetFindViewByItemId_JHandler")]
		public virtual unsafe global::Android.Views.View FindViewByItemId (long p0)
		{
			if (id_findViewByItemId_J == IntPtr.Zero)
				id_findViewByItemId_J = JNIEnv.GetMethodID (class_ref, "findViewByItemId", "(J)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_findViewByItemId_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findViewByItemId", "(J)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isHeaderCollapsed_J;
#pragma warning disable 0169
		static Delegate GetIsHeaderCollapsed_JHandler ()
		{
			if (cb_isHeaderCollapsed_J == null)
				cb_isHeaderCollapsed_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_IsHeaderCollapsed_J);
			return cb_isHeaderCollapsed_J;
		}

		static bool n_IsHeaderCollapsed_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHeaderCollapsed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isHeaderCollapsed_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='ExpandableStickyListHeadersListView']/method[@name='isHeaderCollapsed' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("isHeaderCollapsed", "(J)Z", "GetIsHeaderCollapsed_JHandler")]
		public virtual unsafe bool IsHeaderCollapsed (long p0)
		{
			if (id_isHeaderCollapsed_J == IntPtr.Zero)
				id_isHeaderCollapsed_J = JNIEnv.GetMethodID (class_ref, "isHeaderCollapsed", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isHeaderCollapsed_J, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHeaderCollapsed", "(J)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_setAnimExecutor_Lse_emilsjolander_stickylistheaders_ExpandableStickyListHeadersListView_IAnimationExecutor_;
#pragma warning disable 0169
		static Delegate GetSetAnimExecutor_Lse_emilsjolander_stickylistheaders_ExpandableStickyListHeadersListView_IAnimationExecutor_Handler ()
		{
			if (cb_setAnimExecutor_Lse_emilsjolander_stickylistheaders_ExpandableStickyListHeadersListView_IAnimationExecutor_ == null)
				cb_setAnimExecutor_Lse_emilsjolander_stickylistheaders_ExpandableStickyListHeadersListView_IAnimationExecutor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAnimExecutor_Lse_emilsjolander_stickylistheaders_ExpandableStickyListHeadersListView_IAnimationExecutor_);
			return cb_setAnimExecutor_Lse_emilsjolander_stickylistheaders_ExpandableStickyListHeadersListView_IAnimationExecutor_;
		}

		static void n_SetAnimExecutor_Lse_emilsjolander_stickylistheaders_ExpandableStickyListHeadersListView_IAnimationExecutor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView.IAnimationExecutor p0 = (global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView.IAnimationExecutor)global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView.IAnimationExecutor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimExecutor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAnimExecutor_Lse_emilsjolander_stickylistheaders_ExpandableStickyListHeadersListView_IAnimationExecutor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/class[@name='ExpandableStickyListHeadersListView']/method[@name='setAnimExecutor' and count(parameter)=1 and parameter[1][@type='se.emilsjolander.stickylistheaders.ExpandableStickyListHeadersListView.IAnimationExecutor']]"
		[Register ("setAnimExecutor", "(Lse/emilsjolander/stickylistheaders/ExpandableStickyListHeadersListView$IAnimationExecutor;)V", "GetSetAnimExecutor_Lse_emilsjolander_stickylistheaders_ExpandableStickyListHeadersListView_IAnimationExecutor_Handler")]
		public virtual unsafe void SetAnimExecutor (global::SE.Emilsjolander.Stickylistheaders.ExpandableStickyListHeadersListView.IAnimationExecutor p0)
		{
			if (id_setAnimExecutor_Lse_emilsjolander_stickylistheaders_ExpandableStickyListHeadersListView_IAnimationExecutor_ == IntPtr.Zero)
				id_setAnimExecutor_Lse_emilsjolander_stickylistheaders_ExpandableStickyListHeadersListView_IAnimationExecutor_ = JNIEnv.GetMethodID (class_ref, "setAnimExecutor", "(Lse/emilsjolander/stickylistheaders/ExpandableStickyListHeadersListView$IAnimationExecutor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAnimExecutor_Lse_emilsjolander_stickylistheaders_ExpandableStickyListHeadersListView_IAnimationExecutor_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnimExecutor", "(Lse/emilsjolander/stickylistheaders/ExpandableStickyListHeadersListView$IAnimationExecutor;)V"), __args);
			} finally {
			}
		}

	}
}
