using System;
using System.Collections.Generic;
using Android.Runtime;

namespace SE.Emilsjolander.Stickylistheaders {

	// Metadata.xml XPath interface reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/interface[@name='StickyListHeadersAdapter']"
	[Register ("se/emilsjolander/stickylistheaders/StickyListHeadersAdapter", "", "SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapterInvoker")]
	public partial interface IStickyListHeadersAdapter : global::Android.Widget.IListAdapter {

		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/interface[@name='StickyListHeadersAdapter']/method[@name='getHeaderId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getHeaderId", "(I)J", "GetGetHeaderId_IHandler:SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapterInvoker, StickyExpandableListBinding")]
		long GetHeaderId (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='se.emilsjolander.stickylistheaders']/interface[@name='StickyListHeadersAdapter']/method[@name='getHeaderView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getHeaderView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetHeaderView_ILandroid_view_View_Landroid_view_ViewGroup_Handler:SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapterInvoker, StickyExpandableListBinding")]
		global::Android.Views.View GetHeaderView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2);

	}

	[global::Android.Runtime.Register ("se/emilsjolander/stickylistheaders/StickyListHeadersAdapter", DoNotGenerateAcw=true)]
	internal class IStickyListHeadersAdapterInvoker : global::Java.Lang.Object, IStickyListHeadersAdapter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("se/emilsjolander/stickylistheaders/StickyListHeadersAdapter");
		IntPtr class_ref;

		public static IStickyListHeadersAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStickyListHeadersAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "se.emilsjolander.stickylistheaders.StickyListHeadersAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStickyListHeadersAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IStickyListHeadersAdapterInvoker); }
		}

		static Delegate cb_getHeaderId_I;
#pragma warning disable 0169
		static Delegate GetGetHeaderId_IHandler ()
		{
			if (cb_getHeaderId_I == null)
				cb_getHeaderId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetHeaderId_I);
			return cb_getHeaderId_I;
		}

		static long n_GetHeaderId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHeaderId (p0);
		}
#pragma warning restore 0169

		IntPtr id_getHeaderId_I;
		public unsafe long GetHeaderId (int p0)
		{
			if (id_getHeaderId_I == IntPtr.Zero)
				id_getHeaderId_I = JNIEnv.GetMethodID (class_ref, "getHeaderId", "(I)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallLongMethod (Handle, id_getHeaderId_I, __args);
		}

		static Delegate cb_getHeaderView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetHeaderView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getHeaderView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getHeaderView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetHeaderView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getHeaderView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetHeaderView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetHeaderView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getHeaderView_ILandroid_view_View_Landroid_view_ViewGroup_;
		public unsafe global::Android.Views.View GetHeaderView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			if (id_getHeaderView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getHeaderView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getHeaderView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getHeaderView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_areAllItemsEnabled;
#pragma warning disable 0169
		static Delegate GetAreAllItemsEnabledHandler ()
		{
			if (cb_areAllItemsEnabled == null)
				cb_areAllItemsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AreAllItemsEnabled);
			return cb_areAllItemsEnabled;
		}

		static bool n_AreAllItemsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AreAllItemsEnabled ();
		}
#pragma warning restore 0169

		IntPtr id_areAllItemsEnabled;
		public unsafe global::System.Boolean AreAllItemsEnabled ()
		{
			if (id_areAllItemsEnabled == IntPtr.Zero)
				id_areAllItemsEnabled = JNIEnv.GetMethodID (class_ref, "areAllItemsEnabled", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_areAllItemsEnabled);
		}

		static Delegate cb_isEnabled_I;
#pragma warning disable 0169
		static Delegate GetIsEnabled_IHandler ()
		{
			if (cb_isEnabled_I == null)
				cb_isEnabled_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsEnabled_I);
			return cb_isEnabled_I;
		}

		static bool n_IsEnabled_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnabled (position);
		}
#pragma warning restore 0169

		IntPtr id_isEnabled_I;
		public unsafe global::System.Boolean IsEnabled (int position)
		{
			if (id_isEnabled_I == IntPtr.Zero)
				id_isEnabled_I = JNIEnv.GetMethodID (class_ref, "isEnabled", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (position);
			return JNIEnv.CallBooleanMethod (Handle, id_isEnabled_I, __args);
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
			global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		IntPtr id_getCount;
		public unsafe global::System.Int32 Count {
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getCount);
			}
		}

		static Delegate cb_hasStableIds;
#pragma warning disable 0169
		static Delegate GetGetHasStableIdsHandler ()
		{
			if (cb_hasStableIds == null)
				cb_hasStableIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetHasStableIds);
			return cb_hasStableIds;
		}

		static bool n_GetHasStableIds (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasStableIds;
		}
#pragma warning restore 0169

		IntPtr id_hasStableIds;
		public unsafe global::System.Boolean HasStableIds {
			get {
				if (id_hasStableIds == IntPtr.Zero)
					id_hasStableIds = JNIEnv.GetMethodID (class_ref, "hasStableIds", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasStableIds);
			}
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		IntPtr id_isEmpty;
		public unsafe global::System.Boolean IsEmpty {
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isEmpty);
			}
		}

		static Delegate cb_getViewTypeCount;
#pragma warning disable 0169
		static Delegate GetGetViewTypeCountHandler ()
		{
			if (cb_getViewTypeCount == null)
				cb_getViewTypeCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetViewTypeCount);
			return cb_getViewTypeCount;
		}

		static int n_GetViewTypeCount (IntPtr jnienv, IntPtr native__this)
		{
			global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ViewTypeCount;
		}
#pragma warning restore 0169

		IntPtr id_getViewTypeCount;
		public unsafe global::System.Int32 ViewTypeCount {
			get {
				if (id_getViewTypeCount == IntPtr.Zero)
					id_getViewTypeCount = JNIEnv.GetMethodID (class_ref, "getViewTypeCount", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getViewTypeCount);
			}
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (position));
		}
#pragma warning restore 0169

		IntPtr id_getItem_I;
		public unsafe global::Java.Lang.Object GetItem (int position)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (position);
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_getItem_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getItemId_I;
#pragma warning disable 0169
		static Delegate GetGetItemId_IHandler ()
		{
			if (cb_getItemId_I == null)
				cb_getItemId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetItemId_I);
			return cb_getItemId_I;
		}

		static long n_GetItemId_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemId (position);
		}
#pragma warning restore 0169

		IntPtr id_getItemId_I;
		public unsafe global::System.Int64 GetItemId (int position)
		{
			if (id_getItemId_I == IntPtr.Zero)
				id_getItemId_I = JNIEnv.GetMethodID (class_ref, "getItemId", "(I)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (position);
			return JNIEnv.CallLongMethod (Handle, id_getItemId_I, __args);
		}

		static Delegate cb_getItemViewType_I;
#pragma warning disable 0169
		static Delegate GetGetItemViewType_IHandler ()
		{
			if (cb_getItemViewType_I == null)
				cb_getItemViewType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetItemViewType_I);
			return cb_getItemViewType_I;
		}

		static int n_GetItemViewType_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemViewType (position);
		}
#pragma warning restore 0169

		IntPtr id_getItemViewType_I;
		public unsafe global::System.Int32 GetItemViewType (int position)
		{
			if (id_getItemViewType_I == IntPtr.Zero)
				id_getItemViewType_I = JNIEnv.GetMethodID (class_ref, "getItemViewType", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (position);
			return JNIEnv.CallIntMethod (Handle, id_getItemViewType_I, __args);
		}

		static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int position, IntPtr native_convertView, IntPtr native_parent)
		{
			global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View convertView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_convertView, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup parent = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_parent, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (position, convertView, parent));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		public unsafe global::Android.Views.View GetView (int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent)
		{
			if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (position);
			__args [1] = new JValue (convertView);
			__args [2] = new JValue (parent);
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_registerDataSetObserver_Landroid_database_DataSetObserver_;
#pragma warning disable 0169
		static Delegate GetRegisterDataSetObserver_Landroid_database_DataSetObserver_Handler ()
		{
			if (cb_registerDataSetObserver_Landroid_database_DataSetObserver_ == null)
				cb_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterDataSetObserver_Landroid_database_DataSetObserver_);
			return cb_registerDataSetObserver_Landroid_database_DataSetObserver_;
		}

		static void n_RegisterDataSetObserver_Landroid_database_DataSetObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.DataSetObserver observer = global::Java.Lang.Object.GetObject<global::Android.Database.DataSetObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			__this.RegisterDataSetObserver (observer);
		}
#pragma warning restore 0169

		IntPtr id_registerDataSetObserver_Landroid_database_DataSetObserver_;
		public unsafe void RegisterDataSetObserver (global::Android.Database.DataSetObserver observer)
		{
			if (id_registerDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
				id_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID (class_ref, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (observer);
			JNIEnv.CallVoidMethod (Handle, id_registerDataSetObserver_Landroid_database_DataSetObserver_, __args);
		}

		static Delegate cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
#pragma warning disable 0169
		static Delegate GetUnregisterDataSetObserver_Landroid_database_DataSetObserver_Handler ()
		{
			if (cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == null)
				cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_);
			return cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
		}

		static void n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::SE.Emilsjolander.Stickylistheaders.IStickyListHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.DataSetObserver observer = global::Java.Lang.Object.GetObject<global::Android.Database.DataSetObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterDataSetObserver (observer);
		}
#pragma warning restore 0169

		IntPtr id_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
		public unsafe void UnregisterDataSetObserver (global::Android.Database.DataSetObserver observer)
		{
			if (id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
				id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID (class_ref, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (observer);
			JNIEnv.CallVoidMethod (Handle, id_unregisterDataSetObserver_Landroid_database_DataSetObserver_, __args);
		}

	}

}
