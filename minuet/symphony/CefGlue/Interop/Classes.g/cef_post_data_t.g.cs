//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_post_data_t
    {
        internal cef_base_t _base;
        internal IntPtr _is_read_only;
        internal IntPtr _get_element_count;
        internal IntPtr _get_elements;
        internal IntPtr _remove_element;
        internal IntPtr _add_element;
        internal IntPtr _remove_elements;
        
        // Create
        [DllImport(libcef.DllName, EntryPoint = "cef_post_data_create", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_post_data_t* create();
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_post_data_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_post_data_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_post_data_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_read_only_delegate(cef_post_data_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate UIntPtr get_element_count_delegate(cef_post_data_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void get_elements_delegate(cef_post_data_t* self, UIntPtr* elementsCount, cef_post_data_element_t** elements);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int remove_element_delegate(cef_post_data_t* self, cef_post_data_element_t* element);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int add_element_delegate(cef_post_data_t* self, cef_post_data_element_t* element);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void remove_elements_delegate(cef_post_data_t* self);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_post_data_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_post_data_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // HasOneRef
        private static IntPtr _p2;
        private static has_one_ref_delegate _d2;
        
        public static int has_one_ref(cef_post_data_t* self)
        {
            has_one_ref_delegate d;
            var p = self->_base._has_one_ref;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (has_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_one_ref_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // IsReadOnly
        private static IntPtr _p3;
        private static is_read_only_delegate _d3;
        
        public static int is_read_only(cef_post_data_t* self)
        {
            is_read_only_delegate d;
            var p = self->_is_read_only;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (is_read_only_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_read_only_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // GetElementCount
        private static IntPtr _p4;
        private static get_element_count_delegate _d4;
        
        public static UIntPtr get_element_count(cef_post_data_t* self)
        {
            get_element_count_delegate d;
            var p = self->_get_element_count;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (get_element_count_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_element_count_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // GetElements
        private static IntPtr _p5;
        private static get_elements_delegate _d5;
        
        public static void get_elements(cef_post_data_t* self, UIntPtr* elementsCount, cef_post_data_element_t** elements)
        {
            get_elements_delegate d;
            var p = self->_get_elements;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (get_elements_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_elements_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            d(self, elementsCount, elements);
        }
        
        // RemoveElement
        private static IntPtr _p6;
        private static remove_element_delegate _d6;
        
        public static int remove_element(cef_post_data_t* self, cef_post_data_element_t* element)
        {
            remove_element_delegate d;
            var p = self->_remove_element;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (remove_element_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(remove_element_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self, element);
        }
        
        // AddElement
        private static IntPtr _p7;
        private static add_element_delegate _d7;
        
        public static int add_element(cef_post_data_t* self, cef_post_data_element_t* element)
        {
            add_element_delegate d;
            var p = self->_add_element;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (add_element_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_element_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self, element);
        }
        
        // RemoveElements
        private static IntPtr _p8;
        private static remove_elements_delegate _d8;
        
        public static void remove_elements(cef_post_data_t* self)
        {
            remove_elements_delegate d;
            var p = self->_remove_elements;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (remove_elements_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(remove_elements_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            d(self);
        }
        
    }
}
