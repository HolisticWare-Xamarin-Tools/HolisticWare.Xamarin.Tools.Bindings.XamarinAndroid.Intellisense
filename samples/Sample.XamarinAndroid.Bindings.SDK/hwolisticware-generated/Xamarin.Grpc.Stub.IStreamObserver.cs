using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Grpc.Stub {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.grpc.stub']/interface[@name='StreamObserver']"
	[Register ("io/grpc/stub/StreamObserver", "", "Xamarin.Grpc.Stub.IStreamObserverInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
	public partial interface IStreamObserver : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/interface[@name='StreamObserver']/method[@name='onCompleted' and count(parameter)=0]"
		[Register ("onCompleted", "()V", "GetOnCompletedHandler:Xamarin.Grpc.Stub.IStreamObserverInvoker, Sample.XamarinAndroid.Bindings.SDK")]
		void OnCompleted ();

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/interface[@name='StreamObserver']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler:Xamarin.Grpc.Stub.IStreamObserverInvoker, Sample.XamarinAndroid.Bindings.SDK")]
		void OnError (global::Java.Lang.Throwable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.grpc.stub']/interface[@name='StreamObserver']/method[@name='onNext' and count(parameter)=1 and parameter[1][@type='V']]"
		[Register ("onNext", "(Ljava/lang/Object;)V", "GetOnNext_Ljava_lang_Object_Handler:Xamarin.Grpc.Stub.IStreamObserverInvoker, Sample.XamarinAndroid.Bindings.SDK")]
		void OnNext (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("io/grpc/stub/StreamObserver", DoNotGenerateAcw=true)]
	internal class IStreamObserverInvoker : global::Java.Lang.Object, IStreamObserver {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("io/grpc/stub/StreamObserver", typeof (IStreamObserverInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IStreamObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStreamObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.grpc.stub.StreamObserver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStreamObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCompleted;
#pragma warning disable 0169
		static Delegate GetOnCompletedHandler ()
		{
			if (cb_onCompleted == null)
				cb_onCompleted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCompleted);
			return cb_onCompleted;
		}

		static void n_OnCompleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.Grpc.Stub.IStreamObserver __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.IStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted ();
		}
#pragma warning restore 0169

		IntPtr id_onCompleted;
		public unsafe void OnCompleted ()
		{
			if (id_onCompleted == IntPtr.Zero)
				id_onCompleted = JNIEnv.GetMethodID (class_ref, "onCompleted", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompleted);
		}

		static Delegate cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Ljava_lang_Throwable_ == null)
				cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Throwable_);
			return cb_onError_Ljava_lang_Throwable_;
		}

		static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.Grpc.Stub.IStreamObserver __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.IStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Throwable_;
		public unsafe void OnError (global::Java.Lang.Throwable p0)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_onNext_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnNext_Ljava_lang_Object_Handler ()
		{
			if (cb_onNext_Ljava_lang_Object_ == null)
				cb_onNext_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNext_Ljava_lang_Object_);
			return cb_onNext_Ljava_lang_Object_;
		}

		static void n_OnNext_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.Grpc.Stub.IStreamObserver __this = global::Java.Lang.Object.GetObject<global::Xamarin.Grpc.Stub.IStreamObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNext (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNext_Ljava_lang_Object_;
		public unsafe void OnNext (global::Java.Lang.Object p0)
		{
			if (id_onNext_Ljava_lang_Object_ == IntPtr.Zero)
				id_onNext_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onNext", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNext_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
